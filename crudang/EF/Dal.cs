using crudang.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace crudang.EF
{
    public class Dal:DbContext
    {

        public Dal() : base("dbconnection") { }
        public DbSet<Employee> employess { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("tblEmployee");
            modelBuilder.Entity<Employee>().HasKey(x => x.EmployeeId);

        }
    }
}