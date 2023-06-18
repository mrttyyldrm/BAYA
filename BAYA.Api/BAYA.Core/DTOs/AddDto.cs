using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Core.DTOs
{
    public class AddDto
    {
        public string? county { get; set; }
        public string? districts { get; set; }
        public string? street { get; set; }

        public string? categoryname { get; set; }

        public string? subcategoryname { get; set; }
    }
}
