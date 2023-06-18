using BAYA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Core.DTOs
{
    public class AidNoticeDto : BaseDto
    {

        //Navigations

        public int? CountyId { get; set; }


        public int? DistrictId { get; set; }


        public int? StreetId { get; set; }
    }
}
