using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Core.DTOs
{
    public class StreetDto : BaseDto
    {
        public string StreetAddress { get; set; }
        public int DistrictId { get; set; }
    }
}
