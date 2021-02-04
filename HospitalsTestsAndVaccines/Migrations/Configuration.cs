namespace HospitalsTestsAndVaccines.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using HospitalsTestsAndVaccines.Core;
    using HospitalsTestsAndVaccines.Models;
    using HospitalsTestsAndVaccines.ViewModels;

    internal sealed class Configuration : DbMigrationsConfiguration<HospitalsTestsAndVaccines.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HospitalsTestsAndVaccines.Models.ApplicationDbContext context)
        {
            var Product = new List<Product>
            {

               new Product {
                    ProductName = "AzureTest",
                    ProductCategory = 0,
                    Description ="azure deploy test",
                    Price = 50
               },

               new Product {
                    ProductName = "AzureTest2",
                    ProductCategory = 0,
                    Description ="azure2 deploy test2",
                    Price = 5
               },

               new Product {
                    ProductName = "AzureTest3",
                    ProductCategory = 0,
                    Description ="azure3 deploy test2",
                    Price = 55
               },

               new Product {
                    ProductName = "AzureTest4",
                    ProductCategory = 0,
                    Description ="azure4 deploy test2",
                    Price = 51
               }

            };
            Product.ForEach(s => context.Products.AddOrUpdate(p => p.Price, s));
            context.SaveChanges();
        }
    }
}
