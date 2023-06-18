using AutoMapper;
using BAYA.Core.DTOs;
using BAYA.Core.Entities;
using BAYA.Core.Services;
using BAYA.Core.UnitOfWorks;
using BAYA.Repository.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BAYA.Api.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class AidNoticeController : ControllerBase
    {
        private readonly IAidNoticeService _aidNoticeService;
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public AidNoticeController(IAidNoticeService aidNoticeService, AppDbContext _appDbContext, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _aidNoticeService = aidNoticeService;
            this._appDbContext = _appDbContext;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }



        [HttpGet("{categoryid}/{countyid}")]
        public async Task<IActionResult> GetListById(int categoryid, int countyid)
        {
            var values = await _aidNoticeService.GetAidNoticesById(categoryid, countyid);
            return Ok(values);
        }


        [HttpGet("{categoryid}")]
        public IActionResult GetCountByCategory(int categoryid)
        {

            var values = _aidNoticeService.GetCount(categoryid);
            return Ok(values);
        }


        [HttpGet("{countyId}")]
        public IActionResult GetCounty(int countyId)
        {
            var values = _aidNoticeService.GetCountyCount(countyId);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> AddAidNotice(AidNoticeDto aitNotice)
        {
            var values = await _aidNoticeService.AddAsync(_mapper.Map<AidNotice>(aitNotice));
            return Ok(values);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetAidNoticeById(int id)
        {
            var values = await _aidNoticeService.GetAidNoticesListWithCategoryCounty(id);
            return Ok(values);
        }


        [HttpDelete]
        public async Task<IActionResult> DeleteAidNotice(int id)
        {
            var values = await _aidNoticeService.GetByIdAsync(id);
            await _aidNoticeService.RemoveAsync(values);
            return Ok("Başarıyla silindi");
        }


        [HttpGet("{countyid}/{districtid}")]
        public IActionResult Control(int countyid, int districtid)
        {
            var values = _aidNoticeService.GetCountWithCountyDistrict(countyid, districtid);
            return Ok(values);
        }



        [HttpGet("{countyid}/{districtid}/{streetid}")]
        public IActionResult Control(int countyid, int districtid, int streetid)
        {
            var values = _aidNoticeService.GetCountWithCountyDistrictStreet(countyid, districtid, streetid);
            return Ok(values);
        }

        

        [HttpPost]
        public IActionResult AddDataAitNotion([FromBody] AddDto dto)
        {
            _aidNoticeService.SaveRelatedRecord(dto.county, dto.districts, dto.street, dto.categoryname, dto.subcategoryname);
            return Ok("Success");
        }



    }
}

