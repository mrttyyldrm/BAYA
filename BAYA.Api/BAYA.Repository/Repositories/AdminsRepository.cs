using BAYA.Core.Entities;
using BAYA.Core.Repositories;
using BAYA.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Repository.Repositories
{
    public class AdminsRepository : GenericRepository<Admins>, IAdminsRepository
    {
        public AdminsRepository(AppDbContext context) : base(context)
        {
        }

        public bool CompareAdminInfo(string username, string pass)
        {
            return _context.Adminss.Any(x => x.Username == username && x.Password == pass);
        }
    }
}
