using BAYA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Core.Repositories
{
    public interface ISubCategoryRepository : IGenericRepository<SubCategory>
    {
        public int GetSubCategory(int subcategoryid);

    }
}
