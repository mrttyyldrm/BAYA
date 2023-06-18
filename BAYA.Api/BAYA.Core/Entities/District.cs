using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Core.Entities
{
    public class District : BaseEntity
    {
        public string DistrictAddress { get; set; }



        //public ICollection<Street> Streets { get; set; }

        //public int CountyId { get; set; }
        //public County Counties { get; set; }
       


        public ICollection<AidNotice> AidNotices { get; set; }

    }
}
