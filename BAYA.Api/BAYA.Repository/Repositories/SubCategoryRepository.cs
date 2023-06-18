using BAYA.Core.Entities;
using BAYA.Core.Repositories;
using BAYA.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Repository.Repositories
{
    public class SubCategoryRepository : GenericRepository<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(AppDbContext context) : base(context)
        {
        }

        public int GetSubCategory(int subcategoryid)
        {
            return _context.AidNotices.Include(x => x.SubCategories).Count(x=>x.SubCategoryId==subcategoryid);
        }
    }
}
