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
        private readonly IMapper _mapper;
        public AccountsController(IUnitOfWorkCommon unitOfWork, UserManager<User> userManager, SignInManager<User> signInManager, ApplicationDbContext context, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IServiceResult> Register([FromBody] RegisterDTOs register)
        {
            try
            {
                var user = _mapper.Map<RegisterDTOs, User>(register);
                var result = await _userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
                    var currentUser = await _userManager.FindByNameAsync(user.UserName);
                    var role = await _userManager.AddToRoleAsync(currentUser, "User");
                    return new ServiceResult(payload: currentUser.UserName);
                }
                return new ServiceResult(false, message: result.Errors.ToString());
            }
            catch (Exception e)
            {
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
                    .Include(u => u.Games).ToListAsync();
                var usersDto = _mapper.Map<IEnumerable<User>, IEnumerable<UserDTOs>>(users);
                return new ServiceResult(payload: usersDto);
            }
            catch (Exception e)
            {
                return new ServiceResult(false, e.Message);
            }
        }


        [HttpPut("{id}")]
        [AllowAnonymous]
        public async Task<IServiceResult> BuyGameAsync([FromRoute] string id, [FromBody] RegisterDTOs registerDTOs)
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
                return new ServiceResult(false, e.Message);
            }
        }

    }


}
