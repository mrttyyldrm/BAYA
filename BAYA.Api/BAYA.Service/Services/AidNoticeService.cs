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
    public class AidNoticeService : GenericService<AidNotice>, IAidNoticeService
    {
        private readonly IAidNoticeRepository _aidNoticeRepository;

        public AidNoticeService(IGenericRepository<AidNotice> genericRepository, IUnitOfWork unitOfWorks, IAidNoticeRepository aidNoticeRepository) : base(genericRepository, unitOfWorks)
        {
            _aidNoticeRepository = aidNoticeRepository;
        }

   
        public async Task<List<AidNotice>> GetAidNoticesById(int categoryid, int countyid)
        {
            return await _aidNoticeRepository.GetAidNoticesById(categoryid, countyid);
        }

        public async Task<List<AidNotice>> GetAidNoticesListWithCategoryCounty()
        {
            return await _aidNoticeRepository.GetAidNoticesListWithCategoryCounty();
        }

        public async Task<List<AidNotice>> GetAidNoticesListWithCategoryCounty(int id)
        {
            return await _aidNoticeRepository.GetAidNoticesListWithCategoryCounty(id);
        }

        public int GetCount(int categoryid)
        {
            return _aidNoticeRepository.GetCount(categoryid);
        }

        public int GetCountyCount(int countyId)
        {
            return _aidNoticeRepository.GetCountyCount(countyId);
        }

        public int GetCountWithCountyDistrict(int countyId, int disticntid)
        {
            return _aidNoticeRepository.GetCountWithCountyDistrict(countyId, disticntid);
        }

        public int GetCountWithCountyDistrictStreet(int countyId, int disticntid, int streetid)
        {
            return _aidNoticeRepository.GetCountWithCountyDistrictStreet(countyId, disticntid, streetid);
        }

        public void SaveRelatedRecord(string county, string district, string street, string? categoryname, string? subcategoryname)
        {
            _aidNoticeRepository.SaveRelatedRecord(county, district, street, categoryname, subcategoryname);
        }
    }
}
