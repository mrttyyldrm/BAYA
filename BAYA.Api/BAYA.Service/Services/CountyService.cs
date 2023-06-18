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
    public class CountyService : GenericService<County>, ICountyService
    {
        private readonly ICountyRepository _countyRepository;
        public CountyService(IGenericRepository<County> genericRepository, IUnitOfWork unitOfWorks, ICountyRepository countyRepository) : base(genericRepository, unitOfWorks)
        {
            _countyRepository = countyRepository;
        }

    }
}
