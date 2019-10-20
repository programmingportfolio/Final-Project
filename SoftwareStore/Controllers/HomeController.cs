using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SoftwareStore.Models;
using SoftwareStore.Models.Abstract;
using SoftwareStore.Models.ViewModels;

namespace SoftwareStore.Controllers
{
    public class HomeController : Controller
    {

        //add db context
        public IActionResult Index()
        {
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


        //TODO: Complete show product
        public IActionResult ShowProduct(Product product)
        {

            //product linq lookup here.
            return View(product);
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
