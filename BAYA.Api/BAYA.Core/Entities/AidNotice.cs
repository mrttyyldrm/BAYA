using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Core.Entities
{
    public class AidNotice : BaseEntity
    {


        //Navigations
        
        public int? CategoryId { get; set; }
        public Category? Categories { get; set; }


        public int? SubCategoryId { get; set; }
        public SubCategory? SubCategories { get; set; }


        public int? CountyId { get; set; }
        public County? Counties { get; set; }


        public int? DistrictId { get; set; }
        public District? Districts { get; set; }


        public int? StreetId { get; set; }
        public Street? Streets { get; set; }
    }
}
