using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Core.Entities
{
    public class Category : BaseEntity
    {
        public string  Name { get; set; }



        //Navigations
       // public ICollection<SubCategory> SubCategories { get; set; }
        public ICollection<AidNotice> AidNotices { get; set; }

    }
}
