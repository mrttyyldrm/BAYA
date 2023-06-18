using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Core.Entities
{
    public class HelpCenter : BaseEntity
    {
        public string? Name { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public float? Truth { get; set; }




        //Navigations
        public int CategoryId { get; set; }
        public Category Categories { get; set; }
    }
}
