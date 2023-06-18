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
    public class DistrictService : GenericService<District>, IDistrictService
    {
        public DistrictService(IGenericRepository<District> genericRepository, IUnitOfWork unitOfWorks) : base(genericRepository, unitOfWorks)
        {
        }
    }
}
