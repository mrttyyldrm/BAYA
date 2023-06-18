using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAYA.Core.Entities
{
    public class Admins : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
