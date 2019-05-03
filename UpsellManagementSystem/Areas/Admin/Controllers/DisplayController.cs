using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UpsellManagementSystem.Models;

namespace UpsellManagementSystem.Areas.Admin.Controllers
{
    public class DisplayController : Controller
    {
        public DBEntities _display = new DBEntities();

        // GET: Admin/Display/DisplayProducts
        public ActionResult DisplayProducts()
        {
            return View(_display.Products_174866_MiniProj.ToList());
        }

        // GET: Admin/Display/DisplayCategories
        public ActionResult DisplayCategories()
        {
            return View(_display.Categories_174866_MiniProj.ToList());
        }

        // GET: Admin/Display/DisplayRecommendedProducts
        public ActionResult DisplayRecommendedProducts()
        {
            return View(_display.ProductsRecommend_174866_MiniProj.ToList());
        }

        public ActionResult DeleteProduct(int? id)
        {
            var products = _display.Products_174866_MiniProj.Where(x => x.ProductsId == id).FirstOrDefault();

            return View(products);
        }

        // Post: Admin/Delete/DeleteProduct/id
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteProduct(int id)
        {
            Products_174866_MiniProj product = _display.Products_174866_MiniProj.Where(x => x.ProductsId == id).Single<Products_174866_MiniProj>();
            _display.Products_174866_MiniProj.Remove(product);
            _display.SaveChanges();
            return View();
        }
    }
}