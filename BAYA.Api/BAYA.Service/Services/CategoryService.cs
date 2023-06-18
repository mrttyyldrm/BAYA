using BAYA.Core.Entities;
using BAYA.Core.Repositories;
using BAYA.Core.Services;
using BAYA.Core.UnitOfWorks;
using BAYA.Repository.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Service.Services
{
    public class CategoryService :GenericService<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(IGenericRepository<Category> genericRepository, IUnitOfWork unitOfWorks, ICategoryRepository categoryRepository) : base(genericRepository, unitOfWorks)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<List<Category>> GetCategoriesListWithSub()
        {
            return await _categoryRepository.GetCategoriesListWithSub();
        }
    }
}






