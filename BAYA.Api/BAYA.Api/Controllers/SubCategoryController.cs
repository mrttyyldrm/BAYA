using BAYA.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BAYA.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private readonly ISubCategoryService _subCategoryService;

        public SubCategoryController(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }


        [HttpGet("{subcategoryid}")]
        public IActionResult SubCategoryInfo(int subcategoryid)
        {
            return Ok(_subCategoryService.GetSubCategory(subcategoryid));
        }
    }
}
