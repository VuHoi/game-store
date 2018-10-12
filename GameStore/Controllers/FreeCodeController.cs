using AutoMapper;
using GameStore.Common;
using GameStore.Data;
using GameStore.DTOs;
using GameStore.Exceptions;
using GameStore.Model;
using GameStore.UnitOfWork.Interfaces;
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
    public class FreeCodesController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IUnitOfWorkCommon _unitOfWork;

        public FreeCodesController(IUnitOfWorkCommon unitOfWork, ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }



        [HttpGet]
        [AllowAnonymous]
        public async Task<IServiceResult> GetFreeCodes()
        {
            try
            {
                var freeCodes = await _context.FreeCodes.ToListAsync();
                var freeCodesDto = _mapper.Map<IEnumerable<FreeCode>, IEnumerable<FreeCodeDTOs>>(freeCodes);
                return new ServiceResult(payload: freeCodesDto);
            }
            catch (Exception e)
            {
                return new ServiceResult(false, message: e.Message);
            }
        }

        [HttpGet("{gameId}")]
        [AllowAnonymous]
        public async Task<IServiceResult> GetFreeCodeByGameId([FromRoute] Guid gameId)
        {
            try
            {
                var freeCode = await _context.FreeCodes.Where(f => f.GameId == gameId).ToListAsync();
                var freeCodesDto = _mapper.Map<IEnumerable<FreeCode>, IEnumerable<FreeCodeDTOs>>(freeCode);
                return new ServiceResult(payload: freeCodesDto);
            }
            catch (Exception e)
            {
                return new ServiceResult(false, message: e.Message);
            }
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IServiceResult> PostFreeCode([FromBody] SavedFreeCodeDTOs savedFreeCodeDTOs)
        {
            try
            {
                var freeCode = _mapper.Map<SavedFreeCodeDTOs, FreeCode>(savedFreeCodeDTOs);
                _context.FreeCodes.Add(freeCode);
                if (!await _unitOfWork.CompleteAsync())
                {
                    throw new SaveFailedException(nameof(freeCode));
                }
                return new ServiceResult(payload: " ");
            }
            catch (Exception e)
            {
                return new ServiceResult(false, message: e.Message);
            }
        }
    }
}
