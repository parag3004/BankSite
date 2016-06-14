namespace BankSite.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using BankSite.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<BankSite.DAL.BankDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BankSite.DAL.BankDbContext context)
        {
            var customers = new List<Customer>
            {
                new Customer {CustomerName="Parag Upadhyay", AccountType="Checking" },
                new Customer {CustomerName="Reena Rawal", AccountType="Saving" }
            };

            customers.ForEach(s => context.Customers.AddOrUpdate(p => p.CustomerName, s));
            context.SaveChanges();
        }
    }
}
