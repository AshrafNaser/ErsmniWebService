using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErsmniWebService.Models
{
   public class Category
    {
        public string id { get; set; }
        public string Name { get; set; }
        public virtual List<Drawer> Drawers { get; set; }

    }
}
