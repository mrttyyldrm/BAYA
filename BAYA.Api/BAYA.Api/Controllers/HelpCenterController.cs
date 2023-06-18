using AutoMapper;
using BAYA.Core.DTOs;
using BAYA.Core.Entities;
using BAYA.Core.Services;
using BAYA.Repository.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BAYA.Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class HelpCenterController : ControllerBase
    {
        private readonly IHelpCenterService _helpCenterService;
        private readonly IMapper _mapper;
        private readonly AppDbContext _appDbContext;

        public HelpCenterController(IHelpCenterService helpCenterService, IMapper mapper, AppDbContext appDbContext)
        {
            _helpCenterService = helpCenterService;
            _mapper = mapper;
            _appDbContext = appDbContext;
        }


        [HttpPost]
        public async Task<IActionResult> AddHelpCenter(HelpCenterDto helpCenter)
        {
            var helpCenterDto = await _helpCenterService.AddAsync(_mapper.Map<HelpCenter>(helpCenter));
            return Ok(helpCenterDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> DeleteHelpCenter(int id)
        {
            var values = await _helpCenterService.GetByIdAsync(id);
            if (values == null)
                return NotFound("Belirtilen Id Bulunamadı !");
            await _helpCenterService.RemoveAsync(values);
            return Ok("Başarıyla silindi");
        }


        [HttpGet]
        public async Task<IActionResult> GetAllHelpCenter()
        {
            var values = await _helpCenterService.GetAllHelpCenters();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetHelpCenterWithCategory(int id)
        {
            var values = await _helpCenterService.GetHelpCenterWithCategory(id);
            return Ok(values);
        }

        [HttpGet]
        public async Task<IActionResult> GetHelpCenterCount()
        {
            var values = await _appDbContext.HelpCenters.CountAsync();
            return Ok(values);
        }
        
    }
}
