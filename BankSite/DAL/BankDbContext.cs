using System;
using System.Collections.Generic;
using BankSite.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BankSite.DAL
{
    public class BankDbContext : DbContext 
    {
        public BankDbContext() : base("BankConnectionString")
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
