using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP_T2012E.Data
{
    public class ASP_T2012EContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ASP_T2012EContext() : base("name=ASP_T2012EContextSqlServer")
        {
        }

        public System.Data.Entity.DbSet<ASP_T2012E.Models.Products> Products { get; set; }

        public System.Data.Entity.DbSet<ASP_T2012E.Models.Admin> Admins { get; set; }
    }
}
