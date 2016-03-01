using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ErsmniWebService.Models
{
    class DrawersIntializer : DropCreateDatabaseAlways<ErsmniWebServiceContext>
    {
        protected override void Seed(ErsmniWebServiceContext context)
        {
            //var drawers = new List<Order> {
            //    new Order { Account_Id = "1" , Category_Id = "2" , Collection_Id = "3" , Location_Id="4" , OrderDate="5" , Size="8"
            //    },
            //     new Order { Account_Id = "1" , Category_Id = "2" , Collection_Id = "3" , Location_Id="4" , OrderDate="5" , Size="8"
            //    },
            //    new Order { Account_Id = "1" , Category_Id = "2" , Collection_Id = "3" , Location_Id="4" , OrderDate="5" , Size="8"
            //    },
            //    new Order { Account_Id = "1" , Category_Id = "2" , Collection_Id = "3" , Location_Id="4" , OrderDate="5" , Size="8"
            //    },
            //    new Order { Account_Id = "1" , Category_Id = "2" , Collection_Id = "3" , Location_Id="4" , OrderDate="5" , Size="8"
            //    },
            //};

            var drawers = new Drawer(){
                 Address = "cairo" , Email = "Hotmail" , Name="ash" , Phone="010" , Type="Pastal" } ;
           
            context.Drawrs.Add(drawers);
            context.SaveChanges();
         //   drawers.ForEach(a=>context.Drawrs.Add(a));
           
            //orders.ForEach(a => context.Orders.Add(a));
            //context.SaveChanges();
            base.Seed(context);
        }
  
    }
}
