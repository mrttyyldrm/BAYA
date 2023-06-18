using BAYA.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BAYA.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StreetsController : ControllerBase
    {
        private readonly IStreetService _streetService;

        public StreetsController(IStreetService streetService)
        {
            _streetService = streetService;
        }

        [HttpGet]
        public async Task<IActionResult> StreetInfo()
        {
            var values = await _streetService.GetAllAsync();
            return Ok(values);
        }
    }
}
