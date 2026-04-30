using Microsoft.AspNetCore.Mvc;
using DemoApp1ForDotnet.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoApp1ForDotnet.Controllers
{
    public class ProductController : Controller
    {
        // Fake in-memory database
        static List<Product> products = new List<Product> 
        {
            new Product { Id = 1, Name = "Laptop", Price = 50000 },
            new Product { Id = 2, Name = "Phone", Price = 20000 }
        };


        // 1. Show all products
        public IActionResult Index()
        {
            return View(products);
        }

        // 2. Show details of one product
        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            return View(product);
        }

        // 3. Show form to create product
        public IActionResult Create()
        {
            return View();
        }

        // 4. Handle form submission
        [HttpPost]
        public IActionResult Create(Product p)
        {
            p.Id = products.Max(x => x.Id) + 1;
            products.Add(p);

            return RedirectToAction("Index");
        }
    }
}
