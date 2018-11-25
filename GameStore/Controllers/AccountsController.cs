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
                var user = await _userManager.FindByEmailAsync(register.Email);
                if (user != null) return new ServiceResult(false, message: "Duplicate user");
                user = _mapper.Map<UserSaved, User>(register);
                var result = await _userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
                    var currentUser = await _userManager.FindByNameAsync(user.UserName);
                    var role = await _userManager.AddToRoleAsync(currentUser, "User");
                    _logger.LogInformation($"User {user.Email} with id: {user.Id} created.");
                    return new ServiceResult(payload: currentUser.UserName);
                }
                return new ServiceResult(false, message: " Duplicate UserName " );
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
                    .ThenInclude(g=>g.ImageGames)
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

        [HttpPut("edit-game/{id}")]
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

        [HttpPut("edit-user/{id}")]
        [AllowAnonymous]
        public async Task<IServiceResult> EditUserAsync([FromRoute] string id, [FromBody] RegisterDTOs registerDTOs)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(id);

                user.UserName = registerDTOs.UserName;
                user.PhoneNumber = registerDTOs.PhoneNumber; 
                user.Email = registerDTOs.Email;
                user.SecurityStamp = (Guid.NewGuid()).ToString();
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, registerDTOs.Password);
                await _userManager.UpdateAsync(user);
                await _unitOfWork.CompleteAsync();

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


        [HttpPost("buy/{id}")]
        [AllowAnonymous]
        public async Task<IServiceResult> BuyGameAsync([FromRoute] string id, [FromBody] LikeGameDTOs LikeGameDTOs)
        {
            try
            {
                var userId = id.ToGuid();
                UserGame userGame = new UserGame() { GameId = LikeGameDTOs.Id, PurchaseDate = new DateTime(), UserId = userId };
                _context.UserGames.Add(userGame);
                if (!await _unitOfWork.CompleteAsync())
                {
                    throw new SaveFailedException(nameof(userGame));
                }
                _logger.LogInformation($"User  {userGame.UserId} bought game id: {userGame.GameId} .");
                return new ServiceResult(payload: userGame.GameId);
            }
            catch (Exception e)
            {
                _logger.LogError($"Can't create  a free code {LikeGameDTOs.Id}. {e.Message}");
                return new ServiceResult(false, message: e.Message);
            }
        }


        [HttpPost("like/{id}")]
        [AllowAnonymous]
        public async Task<IServiceResult> LikeGameAsync([FromRoute] string id, [FromBody] LikeGameDTOs LikeGameDTOs)
        {
            try
            {
                var userId = id.ToGuid();
                WishGame wishGame = new WishGame() { GameId = LikeGameDTOs.Id, UserId = userId };
                _context.WishGame.Add(wishGame);
                if (!await _unitOfWork.CompleteAsync())
                {
                    throw new SaveFailedException(nameof(wishGame));
                }
                _logger.LogInformation($"User  {wishGame.UserId} like game id: {wishGame.GameId} .");
                return new ServiceResult(payload: wishGame.GameId);
            }
            catch (Exception e)
            {
                _logger.LogError($"Can't create  a free code {LikeGameDTOs.Id}. {e.Message}");
                return new ServiceResult(false, message: e.Message);
            }
        }

    }


}
