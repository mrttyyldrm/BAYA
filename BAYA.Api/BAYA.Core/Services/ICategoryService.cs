using BAYA.Core.Entities;
using BAYA.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Core.Services
{
    public interface ICategoryService : IGenericService<Category>
    {
        Task<List<Category>> GetCategoriesListWithSub();

    }
}
