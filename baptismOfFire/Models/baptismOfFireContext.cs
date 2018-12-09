using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace baptismOfFire.Models
{
    public class baptismOfFireContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public baptismOfFireContext() : base("name=baptismOfFireContext")
        {
        }

        public System.Data.Entity.DbSet<baptismOfFire.Models.Deployment> Deployments { get; set; }
        public System.Data.Entity.DbSet<baptismOfFire.Models.Server> Servers { get; set; }
        public System.Data.Entity.DbSet<baptismOfFire.Models.Certificate> Certificates { get; set; }
    }
}
