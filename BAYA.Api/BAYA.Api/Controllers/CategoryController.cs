using BAYA.Core.Services;
using BAYA.Repository.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BAYA.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ICategoryService _categoryService;

        public CategoryController(AppDbContext context, ICategoryService categoryService)
        {
            _categoryService = categoryService;
            _context = context;
        }


        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = await _categoryService.GetCategoriesListWithSub();
            return Ok(values);
        }

    }
}
