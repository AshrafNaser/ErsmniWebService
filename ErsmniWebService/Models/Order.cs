using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErsmniWebService.Models
{
   public class Order
    {
        public string id { get; set; }
        public string Status { get; set; }
        public string OrderDate { get; set; }
        public string Size { get; set; }
        public string Phone { get; set; }
        public string Picture { get; set; }
        public string Account_Id { get; set; }
        public string Location_Id { get; set; }
        public string Collection_Id { get; set; }
        public string Category_Id { get; set; }
    }
}
