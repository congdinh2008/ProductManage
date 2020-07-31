using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductManager.Core.Models
{
    public class DbInitializer
    {
        public static void Seed(ProductDbContext context)
        {
            if (context.Categories.Any(x => x.Name == "Category 01"))
            {
                return;
            }
            var categories = new Category[]
            {
                new Category()
                {
                    Name = "Category 01"
                },
                new Category()
                {
                    Name = "Category 02"
                },
                new Category()
                {
                    Name = "Category 03"
                }
            };
            context.Categories.AddRange(categories);

            var products = new Product[]
            {
                new Product()
                {
                    Name = "Product 01",
                    Quantity = 10,
                    ImageUrl = "book-0001.jpg",
                    Price = 15000M,
                    Category = categories.Single(c=>c.Name=="Category 01")
                },
                new Product()
                {
                    Name = "Product 02",
                    Quantity = 16,
                    ImageUrl = "book-0002.jpg",
                    Price = 16000M,
                    Category = categories.Single(c=>c.Name=="Category 01")
                },
                new Product()
                {
                    Name = "Product 03",
                    Quantity = 110,
                    ImageUrl = "book-0003.jpg",
                    Price = 150000M,
                    Category = categories.Single(c=>c.Name=="Category 02")
                },
                new Product()
                {
                    Name = "Product 04",
                    Quantity = 109,
                    ImageUrl = "book-0004.jpg",
                    Price = 25000M,
                    Category = categories.Single(c=>c.Name=="Category 02")
                },
                new Product()
                {
                    Name = "Product 05",
                    Quantity = 13,
                    ImageUrl = "book-0005.jpg",
                    Price = 155000M,
                    Category = categories.Single(c=>c.Name=="Category 03")
                },
            };
            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
