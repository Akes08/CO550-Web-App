using ExampleBlazorApp.Models;
using System.Collections.Immutable;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace ExampleBlazorApp.Services
{
    public class ProductService
    {
        public static readonly List<Product> Products = new List<Product>()
        {
            new()
            {
                Id = 1,
                Name = "Iphone 14",
                Description = "Apple's Latest Device",
                Price = 1000
            },
            new()
            {
                Id = 2,
                Name = "S22 Ultra",
                Description = "Samsungs most powerful device",
                Price = 1100
            },
            new()
            {
                Id = 3,
                Name = "Google Pixel 6",
                Description = "Mobile Phone made by Google",
                Price = 900
            }
        };
    }
}
