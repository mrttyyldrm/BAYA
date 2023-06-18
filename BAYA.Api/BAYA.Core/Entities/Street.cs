using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Core.Entities
{
    public class Street : BaseEntity
    {
        public string StreetAddress { get; set; }



        public ICollection<AidNotice> AidNotices { get; set; }

    }
}
