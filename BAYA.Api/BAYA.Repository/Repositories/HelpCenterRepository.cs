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
    public class HelpCenterRepository : GenericRepository<HelpCenter>, IHelpCenterRepository
    {
        public HelpCenterRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<HelpCenter>> GetAllHelpCenters()
        {
            return await _context.HelpCenters.Include(x=>x.Categories).ToListAsync();
        }

        public async Task<List<HelpCenter>> GetHelpCenterWithCategory(int id)
        {
            return await _context.HelpCenters.Include(x => x.Categories).Where(x=>x.CategoryId == id).ToListAsync();

        }
    }
}
