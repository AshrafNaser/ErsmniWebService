using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErsmniWebService.Models
{
   public class Drawer
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public virtual List<Category> Categories { get; set; }

        
    }
}
