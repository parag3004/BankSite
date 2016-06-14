using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSite.Models;

namespace BankSite.DAL
{
    public class BankInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BankDbContext>
    {
        protected override void Seed(BankDbContext context)
        {
            var customers = new List<Customer>
            {
                new Customer {CustomerName="Parag Upadhyay", AccountType="Checking" },
                new Customer {CustomerName="Reena Rawal", AccountType="Saving" }
            };

            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();            
        }
    }
}
