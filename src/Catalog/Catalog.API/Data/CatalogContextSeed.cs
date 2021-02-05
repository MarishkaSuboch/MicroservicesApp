using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name = "Iphone X",
                    Summary = "asd",
                    Description = "asd",
                    ImageFile = "prod0",
                    Price = 900,
                    Category = "Smart phone new"
                },
                new Product()
                {
                    Name = "Iphone X1",
                    Summary = "asd",
                    Description = "asd",
                    ImageFile = "prod1",
                    Price = 910,
                    Category = "Smart phone"
                },
                new Product()
                {
                    Name = "Iphone X2",
                    Summary = "asd",
                    Description = "asd",
                    ImageFile = "prod2",
                    Price = 920,
                    Category = "Smart phone"
                },
                new Product()
                {
                    Name = "Iphone X3",
                    Summary = "asd",
                    Description = "asd",
                    ImageFile = "prod3",
                    Price = 930,
                    Category = "Smart phone"
                },
                new Product()
                {
                    Name = "Iphone X4",
                    Summary = "asd",
                    Description = "asd",
                    ImageFile = "prod4",
                    Price = 940,
                    Category = "Smart phone"
                },
                new Product()
                {
                    Name = "Iphone X5",
                    Summary = "asd",
                    Description = "asd",
                    ImageFile = "prod5",
                    Price = 950,
                    Category = "Smart phone"
                }
            };
        }
    }
}
