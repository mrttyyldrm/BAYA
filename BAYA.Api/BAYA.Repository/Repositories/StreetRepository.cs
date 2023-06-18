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
    public class StreetRepository : GenericRepository<Street>, IStreetRepository
    {
        public StreetRepository(AppDbContext context) : base(context)
        {
        }
    }
}
