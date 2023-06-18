using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Core.Entities
{
    public class County : BaseEntity
    {
        public string CountyAddress { get; set; }


        //public ICollection<District> Districts { get; set; }

        public ICollection<AidNotice> AidNotices { get; set; }

  

    }
}
