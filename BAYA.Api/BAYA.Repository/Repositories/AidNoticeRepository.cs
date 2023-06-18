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
    public class AidNoticeRepository : GenericRepository<AidNotice>, IAidNoticeRepository
    {
        public AidNoticeRepository(AppDbContext context) : base(context)
        {
        }


        public async Task<List<AidNotice>> GetAidNoticesById(int categoryid, int countyid)
        {
            return await _context.AidNotices
                .Include(x => x.Categories)
                .Include(x => x.Counties)
                .Include(x=>x.Streets).Include(x=>x.Districts)
                .Where(x => x.CategoryId == categoryid && x.CountyId == countyid).ToListAsync();
        }

        public async Task<List<AidNotice>> GetAidNoticesListWithCategoryCounty()
        {
            return await _context.AidNotices
                .Include(x => x.Categories)
                
                .Include(x => x.Counties).Include(x => x.Streets).Include(x => x.Districts)
                .ToListAsync();

        }

        public async Task<List<AidNotice>> GetAidNoticesListWithCategoryCounty(int id)
        {
            return await _context.AidNotices
                .Include(x => x.Categories)
                .Include(x => x.Counties).Include(x => x.Streets).Include(x => x.Districts)
                .Where(x => x.Id == id)
                .ToListAsync();
        }

        public int GetCount(int categoryid)
        {

            return _context.AidNotices.Include(x => x.Categories).Count(x => x.CategoryId == categoryid);

        }

        public int GetCountyCount(int countyId)
        {
            return _context.AidNotices.Include(x => x.Counties).Count(x => x.CountyId == countyId);
        }

        public int GetCountWithCountyDistrict(int countyId, int disticntid)
        {
            return _context.AidNotices.Include(x => x.Counties).Include(x=>x.Districts).Count(x => x.CountyId == countyId && x.DistrictId == disticntid);
        }

        public int GetCountWithCountyDistrictStreet(int countyId, int disticntid, int streetid)
        {
            return _context.AidNotices.Include(x => x.Counties).Include(x => x.Districts).Include(x=>x.Streets).Count(x => x.CountyId == countyId && x.DistrictId == disticntid  && x.StreetId == streetid);
        }

        public void SaveRelatedRecord(string county, string district, string street, string? categoryname, string? subcategoryname)
        {
            try
            {
                // İlgili tabloyu ve string değerin kontrol edilmesi
                var existCounty = _context.Counties.FirstOrDefault(r => r.CountyAddress == county);
                var existngDistrict = _context.Districts.FirstOrDefault(r => r.DistrictAddress == district);
                var existngStreet = _context.Streets.FirstOrDefault(r => r.StreetAddress == street);
                var existingCategory = categoryname != null ? _context.Categories.FirstOrDefault(r => r.Name == categoryname) : null;
                var existingSubcategory = subcategoryname != null ? _context.SubCategories.FirstOrDefault(r => r.Name == subcategoryname) : null;

                // Var olan kayıt varsa ilişkili tabloya ID'yi kaydetme
                var relatedRecord = new AidNotice
                {
                    CountyId = existCounty.Id,
                    DistrictId = existngDistrict.Id,
                    StreetId = existngStreet.Id,
                    CategoryId = existingCategory != null ? existingCategory.Id : null,
                    SubCategoryId = existingSubcategory != null ? existingSubcategory.Id : null
                };

                _context.AidNotices.Add(relatedRecord);                
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Hata ayrıntılarını yakala
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}

