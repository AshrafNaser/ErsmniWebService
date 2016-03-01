using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErsmniWebService.Models
{
   public class Forbidden
    {
        public string id { get; set; }
        public DateTime ForbiddenDate { get; set; }
        public string Type { get; set; }
        public string Reason { get; set; }
        public DateTime BannedDate { get; set; }
        public string Account_Id { get; set; }

    }
}
