using AutoMapper;
using GameStore.Common;
using GameStore.Data;
using GameStore.DTOs;
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
    public class PublishersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public PublishersController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,User")]
        [HttpGet]
        [AllowAnonymous]
        public async Task<IServiceResult> GetCategories()
        {
            try
            {
                var publishers = await _context.Publishers.Include(c => c.Games).ToListAsync();
                var publishersDto = _mapper.Map<IEnumerable<Publisher>, IEnumerable<PublisherDTOs>>(publishers);
                return new ServiceResult(payload: publishersDto);
            }
            catch (Exception e)
            {
                return new ServiceResult(false, message: e.Message);
            }
        }

        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,User")]
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetPublisherById([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var publisher = await _context.Publishers.SingleOrDefaultAsync(g => g.Id == id);

            if (publisher == null)
            {
                return NotFound();
            }

            return Ok(publisher);
        }

        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        [HttpPost]
        [AllowAnonymous]
        public IActionResult PostPublisher([FromBody] Publisher publisher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _context.Publishers.Add(publisher);
            _context.SaveChangesAsync();

            return Ok(publisher);
        }

        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPublisher([FromRoute] Guid id, [FromBody] Publisher publisher)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != publisher.Id)
            {
                return BadRequest();
            }

            _context.Entry(publisher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PublisherExists(id))
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
        public async Task<IActionResult> DeletePublisher([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var publisher = await _context.Publishers.SingleOrDefaultAsync(m => m.Id == id);
            if (publisher == null)
            {
                return NotFound();
            }

            _context.Publishers.Remove(publisher);
            await _context.SaveChangesAsync();

            return Ok(publisher);
        }

        private bool PublisherExists(Guid id)
        {
            return _context.Publishers.Any(e => e.Id == id);
        }
    }
}
