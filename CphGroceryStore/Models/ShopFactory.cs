using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CphGroceryStore.Models;

namespace groceryStore.Models
{
    public class ShopFactory : DbContext
    {
        public ShopFactory()
        {
            Database.SetInitializer(new ShopInitializer());
        }
        public DbSet<Product> Products { get; set; }
    }

    public class ShopInitializer : DropCreateDatabaseIfModelChanges<ShopFactory>
    {
        protected override void Seed(ShopFactory context)
        {
            context.Products.Add(new Product()
            {
                Name = "Yoghurt",
                Description = "This creamy one will melt you",
                Price = 5.4M,
                ImageName = "yoghurt"
            });
            context.Products.Add(new Product()
            {
                Name = "Cleaning lotion",
                Description = "Nothing gets in its way",
                Price = 64M,
                ImageName = "spray"
            });
            context.Products.Add(new Product()
            {
                Name = "Banana",
                Description = "Hungry? That's going to get you satisfied",
                Price = 3M,
                ImageName = "banana"
            });



          
        }
    }
}