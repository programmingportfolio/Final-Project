using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoftwareStore.Data;
using SoftwareStore.Infrastructure;
using SoftwareStore.Models;
using SoftwareStore.Models.Abstract;
using SoftwareStore.Models.Concrete.Products;
using SoftwareStore.Models.ViewModels;
using SoftwareStore.Models.ViewModels.Abstract;
using SoftwareStore.Models.ViewModels.Concrete;

namespace SoftwareStore.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //var user = User.Identity.Name;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Category()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }


        //add routing logic
        [HttpGet]
        public IActionResult Product(string productName)
        {

            var product = _context.Softwares
                .Where(p => p.ProductName == productName)
                .FirstOrDefault();

            if (product is Software)
            {
                var productViewModel = Conversion.ConvertToViewModel((Software)product);

                return View(productViewModel);
            }
            else
            {
                Conversion.ConvertToViewModel(product);
                return View("Index");
            }
           
        }

        [HttpPost]
        public IActionResult Product(IProduct product)
        {
            return View("Cart", product);
        }
        public IActionResult Products()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
