using BAYA.Core.Entities;
using BAYA.Core.Repositories;
using BAYA.Core.Services;
using BAYA.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Service.Services
{
    public class SubCategoryService : GenericService<SubCategory>, ISubCategoryService
    {
        private readonly ISubCategoryRepository _subCategoryRepository;
        public SubCategoryService(IGenericRepository<SubCategory> genericRepository, IUnitOfWork unitOfWorks, ISubCategoryRepository subCategoryRepository) : base(genericRepository, unitOfWorks)
        {
            _subCategoryRepository = subCategoryRepository;
        }

        public int GetSubCategory(int subcategoryid)
        {
            return _subCategoryRepository.GetSubCategory(subcategoryid);
        }
    }
}
