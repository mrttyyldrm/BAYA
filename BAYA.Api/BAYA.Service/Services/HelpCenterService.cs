using AutoMapper;
using BAYA.Core.DTOs;
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
    public class HelpCenterService : GenericService<HelpCenter>, IHelpCenterService
    {
        private readonly IHelpCenterRepository _helpCenterRepository;
        private readonly IMapper _mapper;
        public HelpCenterService(IGenericRepository<HelpCenter> genericRepository, IUnitOfWork unitOfWorks, IHelpCenterRepository helpCenterRepository, IMapper mapper) : base(genericRepository, unitOfWorks)
        {
            _helpCenterRepository = helpCenterRepository;
            _mapper = mapper;
        }

        public async Task<List<HelpCenter>> GetAllHelpCenters()
        {
            return await _helpCenterRepository.GetAllHelpCenters();
        }

        public async Task<List<HelpCenter>> GetHelpCenterWithCategory(int id)
        {
            return await _helpCenterRepository.GetHelpCenterWithCategory(id);
        }
    }
}
