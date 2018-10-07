using AutoMapper;
using GameStore.Common;
using GameStore.Data;
using GameStore.DTOs;
using GameStore.Model;
using GameStore.Model.Resource;
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
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public AccountsController(UserManager<User> userManager, SignInManager<User> signInManager, ApplicationDbContext context, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterDTOs register)
        {
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<RegisterDTOs, User>(register);
                var result = await _userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
                    var currentUser = await _userManager.FindByNameAsync(user.UserName);
                    var role = await _userManager.AddToRoleAsync(currentUser, "User");

                    return Ok(currentUser.UserName);
                }
                //error register failed
                //AddErrors(result);
                return Json(result.Errors);
            }

            // If we got this far, something failed, redisplay form
            return BadRequest();
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IServiceResult> GetUsers()
        {
            var users = await _context.Users
                .Include(u=>u.WishGames)
                .ThenInclude(g => g.Game)
                .Include(u=>u.Games).ToListAsync();
            var usersDto = _mapper.Map<IEnumerable<User>, IEnumerable<UserDTOs>>(users);
            return new ServiceResult(payload: usersDto);
        }

    }


}
