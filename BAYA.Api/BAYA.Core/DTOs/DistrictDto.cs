using BAYA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Core.DTOs
{
    public class DistrictDto : BaseDto
    {
        public string DistrictAddress { get; set; }
        public int CountyId { get; set; }
    }
}
