using BAYA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Core.Repositories
{
    public interface IAidNoticeRepository : IGenericRepository<AidNotice>
    {
        Task<List<AidNotice>> GetAidNoticesListWithCategoryCounty();
        Task<List<AidNotice>> GetAidNoticesById(int categoryid, int countyid);
        Task<List<AidNotice>> GetAidNoticesListWithCategoryCounty(int id);

        public int GetCount(int categoryid);
        public int GetCountyCount(int countyId);



        public int GetCountWithCountyDistrict(int countyId,int disticntid);
        public int GetCountWithCountyDistrictStreet(int countyId,int disticntid,int streetid);


        public void SaveRelatedRecord(string county, string district, string street, string? categoryname, string? subcategoryname);

    }
}
