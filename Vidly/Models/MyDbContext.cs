using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
//using System.Data.Entity.ModelConfiguration.Conventions;

namespace Vidly.Models
{
    public class MyDbContext:DbContext
    {
        //public MyDbContext()//:base("name=MyDbContext")
        //{

        //}
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipType { get; set; }





        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //    {
        //        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //    }

    }
}