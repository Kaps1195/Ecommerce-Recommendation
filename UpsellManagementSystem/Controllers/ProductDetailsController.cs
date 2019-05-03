using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UpsellManagementSystem.Models;

namespace UpsellManagementSystem.Controllers
{
    public class ProductDetailsController : Controller
    {
        public DBEntities _product = new DBEntities();

        public ActionResult ProductDetail(string submitProduct)
        {
            var product = _product.Products_174866_MiniProj.Where(x => x.ModelName == submitProduct).FirstOrDefault();
            return View(product);
        }
    }
}