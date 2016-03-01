using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErsmniWebService.Models
{
   public class Account
    {
        public string id { get; set; }
        public string Name { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Profile_Picture { get; set; }
        public string Forbidden_Times { get; set; }

    }
}
