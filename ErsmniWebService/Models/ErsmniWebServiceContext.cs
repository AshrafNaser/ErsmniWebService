using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ErsmniWebService.Models
{
    public class ErsmniWebServiceContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ErsmniWebServiceContext() : base("name=ErsmniWebServiceContext")
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Drawer> Drawrs { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Product> Prouducts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Forbidden> Forbiddens { get; set; }

    }
}
