using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCSample.Models;
using System.Data.Entity;

namespace MVCSample.DataAccessLayer
{
    public class SalesERPDB:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);
        }
    }
}