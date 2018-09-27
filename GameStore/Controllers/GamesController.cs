using GameStore.Data;
using GameStore.Model;
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

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,User")]
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<Game> GetGames()
        {
            return _context.Games.Include(g=>g.Categories);
        }

        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,User")]
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetGameById([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var game = await _context.Games.Include(ge=>ge.Publisher).SingleOrDefaultAsync(g => g.Id == id);

            if (game == null)
            {
                return NotFound();
            }

            return Ok(game);
        }

        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        [HttpPost]
        [AllowAnonymous]
        public IActionResult PostGame([FromBody] Game game)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _context.Games.Add(game);
            _context.SaveChangesAsync();

            return Ok(game);
        }

        [HttpPost("buy")]
        [AllowAnonymous]
        public IActionResult BuyGame([FromBody] UserGame userGame)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _context.UserGames.Add(userGame);
            _context.SaveChangesAsync();

            return Ok(userGame);
        }

        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGame([FromRoute] Guid id, [FromBody] Game game)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != game.Id)
            {
                return BadRequest();
            }

            _context.Entry(game).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
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
