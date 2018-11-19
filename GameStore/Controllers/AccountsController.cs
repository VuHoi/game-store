using AutoMapper;
using GameStore.Common;
using GameStore.Data;
using GameStore.DTOs;
using GameStore.Exceptions;
using GameStore.Extention;
using GameStore.Model;
using GameStore.Model.Resource;
using GameStore.UnitOfWork.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Controllers
{
    [Produces("application/json")]
    [Route("/api/[controller]")]
    public class AccountsController : Controller
    {
        private readonly IUnitOfWorkCommon _unitOfWork;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ApplicationDbContext _context;
        private readonly ILogger<AccountsController>_logger;
        private readonly IMapper _mapper;
        public AccountsController(IUnitOfWorkCommon unitOfWork,
                                  UserManager<User> userManager,
                                  SignInManager<User> signInManager,
                                  ApplicationDbContext context,
                                  IMapper mapper,
                                  ILogger<AccountsController> logger)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IServiceResult> Register([FromBody] UserSaved register)
        {
            try
            {

                var user = _mapper.Map<UserSaved, User>(register);
                var result = await _userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
                    var currentUser = await _userManager.FindByNameAsync(user.UserName);
                    var role = await _userManager.AddToRoleAsync(currentUser, "User");
                    _logger.LogInformation($"User {user.Email} with id: {user.Id} created.");
                    return new ServiceResult(payload: currentUser.UserName);
                }
                return new ServiceResult(false, message: result.Errors.ToString());
        }
            catch (Exception e)
            {
                _logger.LogError($"Can not create user {register.Email}. {e.Message}");
                return new ServiceResult(false, message: e.Message);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IServiceResult> GetUsersAsync()
        {
            try
            {
                var users = await _context.Users
                    .Include(u => u.WishGames)
                    .ThenInclude(g => g.Game)
                    .Include(u => u.Games)
                    .Include(u=>u.ImageUser).ToListAsync();

                var usersDto = _mapper.Map<IEnumerable<User>, IEnumerable<UserDTOs>>(users);
                return new ServiceResult(payload: usersDto);
            }
            catch (Exception e)
            {
                _logger.LogError($"Can not get all users. {e.Message}");
                return new ServiceResult(false, e.Message);
            }
        }


        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IServiceResult> GetUserByIdAsync([FromRoute] Guid id)
        {
            try
            {
                var user = await _context.Users
                    .Include(u => u.WishGames)
                    .ThenInclude(g => g.Game)
                    .Include(u => u.Games).SingleOrDefaultAsync(u=> u.Id == id);
                var usersDto = _mapper.Map<User, UserDTOs>(user);
                return new ServiceResult(payload: usersDto);
            }
            catch (Exception e)
            {
                _logger.LogError($"Can not get all users. {e.Message}");
                return new ServiceResult(false, e.Message);
            }
        }

        [HttpPut("{id}")]
        [AllowAnonymous]
        public async Task<IServiceResult> EditGameAsync([FromRoute] string id, [FromBody] RegisterDTOs registerDTOs)
        {
            try
            {
                var userId = id.ToGuid();
                var user = await _context.Users.Where(u => u.Id == userId).Include(u => u.WishGames).Include(u => u.Games).SingleAsync();

                _mapper.Map<RegisterDTOs, User>(registerDTOs, user);
                if (!await _unitOfWork.CompleteAsync())
                {
                    throw new SaveFailedException(nameof(user));
                }

                user = await _userManager.FindByIdAsync(id);
                var usersDto = _mapper.Map<User, UserDTOs>(user);
                return new ServiceResult(payload: usersDto);
            }
            catch (Exception e)
            {
                _logger.LogError($"Can not edit user {registerDTOs.Email} because  {e.Message}");
                return new ServiceResult(false, e.Message);
            }
        }



        [HttpPut("buy/{id}")]
        [AllowAnonymous]
        public async Task<IServiceResult> BuyGameAsync([FromRoute] string id, [FromBody] BuyGameDTOs registerDTOs)
        {
            try
            {
                var userId = id.ToGuid();
                var user = await _context.Users.Where(u => u.Id == userId).Include(u => u.WishGames).Include(u => u.Games).SingleAsync();

                _mapper.Map<BuyGameDTOs, User>(registerDTOs, user);
                if (!await _unitOfWork.CompleteAsync())
                {
                    throw new SaveFailedException(nameof(user));
                }

                user = await _userManager.FindByIdAsync(id);
                var usersDto = _mapper.Map<User, UserDTOs>(user);
                return new ServiceResult(payload: usersDto);
            }
            catch (Exception e)
            {
                _logger.LogError($"Can not buy this game. {e.Message}");
                return new ServiceResult(false, e.Message);
            }
        }


        [HttpPut("like/{id}")]
        [AllowAnonymous]
        public async Task<IServiceResult> LikeGameAsync([FromRoute] string id, [FromBody] LikeGameDTOs likeGameDTOs)
        {
            try
            {
                var userId = id.ToGuid();
                var user = await _context.Users.Where(u => u.Id == userId).Include(u => u.WishGames).SingleAsync();

                _mapper.Map<LikeGameDTOs, User>(likeGameDTOs, user);
                if (!await _unitOfWork.CompleteAsync())
                {
                    throw new SaveFailedException(nameof(user));
                }

                user = await _userManager.FindByIdAsync(id);
                var usersDto = _mapper.Map<User, UserDTOs>(user);
                return new ServiceResult(payload: usersDto);
            }
            catch (Exception e)
            {
                _logger.LogError($"Can not add this game. {e.Message}");
                return new ServiceResult(false, e.Message);
            }
        }

    }


}
