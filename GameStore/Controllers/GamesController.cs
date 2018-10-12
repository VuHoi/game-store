using AutoMapper;
using GameStore.Common;
using GameStore.Data;
using GameStore.DTOs;
using GameStore.Exceptions;
using GameStore.Model;
using GameStore.UnitOfWork.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
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
    public class GamesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkCommon _unitOfWork;
        public GamesController(IUnitOfWorkCommon unitOfWork,ApplicationDbContext context, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _mapper = mapper;
        }

        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,User")]
        [HttpGet]
        [AllowAnonymous]
        public async Task<IServiceResult> GetGames()
        {
            try
            {
                var games = await _context.Games
                .Include(g => g.Members)
                .ThenInclude(m => m.User)
                .Include(g => g.FavoriteMembers)
                .ThenInclude(m => m.User)
                .Include(g => g.Categories)
                .ThenInclude(c => c.Category)
                .Include(g => g.Publisher)
                .ToListAsync();

                var gamesDto = _mapper.Map<IEnumerable<Game>, IEnumerable<GameDTOs>>(games);
                return new ServiceResult(payload: gamesDto);
            }
            catch (Exception e)
            {
                return new ServiceResult(false, e.Message);
            }
        }


        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,User")]
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IServiceResult> GetGameById([FromRoute] Guid id)
        {

            try
            {
                var game = await _context.Games
                .Include(g => g.Members)
                .ThenInclude(m => m.User)
                .Include(g => g.FavoriteMembers)
                .ThenInclude(m => m.User)
                .Include(g => g.Categories)
                .ThenInclude(c => c.Category)
                .Include(g => g.Publisher)
                .SingleOrDefaultAsync(g => g.Id == id);
                if (game == null)
                {
                    throw new NotFoundException(nameof(game), id);
                }

                var gameDto = _mapper.Map<Game, GameDTOs>(game);

               
                return new ServiceResult(payload: gameDto);
            }
            catch (Exception e)
            {
                return new ServiceResult(false, e.Message);
            }

        }

        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        [HttpPost]
        [AllowAnonymous]
        public async Task<IServiceResult> PostGame([FromBody] SavedGameDTOs saveGameDTOs)
        {
            try
            {
                var game = _mapper.Map<SavedGameDTOs, Game>(saveGameDTOs);
                _context.Games.Add(game);
                if (!await _unitOfWork.CompleteAsync())
                {
                    throw new SaveFailedException(nameof(game));
                }
                game= await _context.Games
                .Include(g => g.Members)
                .ThenInclude(m => m.User)
                .Include(g => g.FavoriteMembers)
                .ThenInclude(m => m.User)
                .Include(g => g.Categories)
                .ThenInclude(c => c.Category)
                .Include(g => g.Publisher)
                .SingleOrDefaultAsync(g => g.Id == game.Id);

                var recallGameDTO = _mapper.Map<Game, GameDTOs>(game);
                return new ServiceResult(payload: recallGameDTO);
            }
            catch(Exception e)
            {
                return new ServiceResult(false, message: e.Message);
            }
        }

        

        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IServiceResult> PutGame([FromRoute] Guid id, [FromBody] SavedGameDTOs savedGameDTOs)
        {
            if (id != savedGameDTOs.Id)
            {
                throw new NotFoundException(nameof(savedGameDTOs), id);
            }
            try
            {
                var game = _mapper.Map<SavedGameDTOs, Game>(savedGameDTOs);

                _context.Entry(game).State = EntityState.Modified;

                if (!await _unitOfWork.CompleteAsync())
                {
                    throw new SaveFailedException(nameof(game));
                }

                game = await _context.Games
                .Include(g => g.Members)
                .ThenInclude(m => m.User)
                .Include(g => g.FavoriteMembers)
                .ThenInclude(m => m.User)
                .Include(g => g.Categories)
                .ThenInclude(c => c.Category)
                .Include(g => g.Publisher)
                .SingleOrDefaultAsync(g => g.Id == game.Id);

                var recallGameDTO = _mapper.Map<Game, GameDTOs>(game);
                return new ServiceResult(payload: recallGameDTO);
            }
            catch (DbUpdateConcurrencyException e)
            {
                if (!GameExists(id))
                {
                    throw new NotFoundException(nameof(savedGameDTOs), id);
                }
                return new ServiceResult(false,message: e.Message);
            }
        }

        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGame([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var device = await _context.Games.SingleOrDefaultAsync(m => m.Id == id);
            if (device == null)
            {
                return NotFound();
            }

            _context.Games.Remove(device);
            await _context.SaveChangesAsync();

            return Ok(device);
        }

        private bool GameExists(Guid id)
        {
            return _context.Games.Any(e => e.Id == id);
        }
    }
}
