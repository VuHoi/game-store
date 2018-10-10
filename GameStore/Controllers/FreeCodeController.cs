using AutoMapper;
using GameStore.Common;
using GameStore.Data;
using GameStore.DTOs;
using GameStore.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.Controllers
{
    public class FreeCodeController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public FreeCodeController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        [HttpGet]
        [AllowAnonymous]
        public async Task<IServiceResult> GetFreeCodes()
        {
            try
            {
                var freeCodes = await _context.FreeCodes.Include(c => c.Game).ToListAsync();
                var freeCodesDto = _mapper.Map<IEnumerable<FreeCode>, IEnumerable<FreeCodeDTOs>>(freeCodes);
                return new ServiceResult(payload: freeCodesDto);
            }
            catch (Exception e)
            {
                return new ServiceResult(false, message: e.Message);
            }
        }
    }
}
