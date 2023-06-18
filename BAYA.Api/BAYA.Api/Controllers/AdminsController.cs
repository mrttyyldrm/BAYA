using BAYA.Core.Entities;
using BAYA.Core.Services;
using BAYA.Repository.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BAYA.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {

        private readonly IAdminsService _adminsService;

        public AdminsController(IAdminsService adminsService)
        {
            _adminsService = adminsService;
        }

        [HttpGet("{pass}/{username}")]
        public IActionResult CompareAdminInfos(string pass, string username)
        {
            bool status = _adminsService.CompareAdminInfo(pass, username);
            if (status != false)
            {
                return Ok("Giriş Başarılı");
            }
            else
                return BadRequest("Giriş Başarısız");
            
        }
    }
}
