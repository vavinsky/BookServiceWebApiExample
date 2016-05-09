using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BoockService.Models
{
    public class BoockServiceContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public BoockServiceContext() : base("name=BoockServiceContext")
        {
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);

            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
        }

        public System.Data.Entity.DbSet<BoockService.Models.Author> Authors { get; set; }

        public System.Data.Entity.DbSet<BoockService.Models.Book> Books { get; set; }
    }
}
