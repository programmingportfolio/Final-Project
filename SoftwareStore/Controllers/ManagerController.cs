using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SoftwareStore.Data;
using SoftwareStore.Models.Abstract;
using SoftwareStore.Models.Concrete.Identity;
using SoftwareStore.Models.Concrete.Products;
using SoftwareStore.Models.ViewModels.Concrete;

namespace SoftwareStore.Controllers
{
    public class ManagerController : Controller
    {
        
        // GET: Manager
        public ActionResult Index()
        {
            return View();
        }

        // GET: Manager/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Manager/Create
        public ActionResult Create(Product product)
        {
            //add to db
            return View(product);
        }

        // POST: Manager/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Manager/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Manager/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Manager/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Manager/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult CreateProduct(/*int UserId*/)
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Software s)
        {
            var software = new Software
            {
                isSubscription = s.isSubscription,
                isDownload = s.isDownload,
                isDownSub = s.isDownSub,
                UserName = s.UserName,
                ProductName = s.ProductName,
                ProductCategory = s.ProductCategory,
                ShortDescription = s.ShortDescription,
                LongDescription = s.LongDescription,
                Price = s.Price,
                Quantity = s.Quantity,
                EasyUrl = s.EasyUrl,
                VideoUrl = s.VideoUrl,
                PictureUrl1 = s.PictureUrl1,
                PictureUrl2 = s.PictureUrl2,
                PictureUrl3 = s.PictureUrl3,
                PictureUrl4 = s.PictureUrl4,
                PictureUrl5 = s.PictureUrl5,
                PictureUrl6 = s.PictureUrl6,
                PictureUrl7 = s.PictureUrl7,
                PictureUrl8 = s.PictureUrl8,
            };

            return RedirectToAction("Index", "Home");
        }
    }
}