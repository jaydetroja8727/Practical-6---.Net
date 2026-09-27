using System.Collections.Generic;
using System.Web.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Gaming Laptop",
                    Category = "Computers",
                    Price = 72000
                },

                new Product
                {
                    Id = 2,
                    Name = "Wireless Earbuds",
                    Category = "Audio",
                    Price = 3200
                },

                new Product
                {
                    Id = 3,
                    Name = "Smartphone",
                    Category = "Mobiles",
                    Price = 28000
                },

                new Product
                {
                    Id = 4,
                    Name = "Mechanical Keyboard",
                    Category = "Accessories",
                    Price = 2800
                },

                new Product
                {
                    Id = 5,
                    Name = "Smart Watch",
                    Category = "Wearables",
                    Price = 4500
                },

                new Product
                {
                    Id = 6,
                    Name = "Bluetooth Speaker",
                    Category = "Audio",
                    Price = 2500
                }
            };

            return View(products);
        }
    }
}