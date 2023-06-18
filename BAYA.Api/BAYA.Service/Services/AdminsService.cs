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
    public class AdminsService : GenericService<Admins>, IAdminsService
    {
        private readonly IAdminsRepository _adminsRepository;
        public AdminsService(IGenericRepository<Admins> genericRepository, IUnitOfWork unitOfWorks, IAdminsRepository adminsRepository) : base(genericRepository, unitOfWorks)
        {
            _adminsRepository = adminsRepository;
        }

        public bool CompareAdminInfo(string username, string pass)
        {
            return _adminsRepository.CompareAdminInfo(username, pass);
        }

       
    }
}
