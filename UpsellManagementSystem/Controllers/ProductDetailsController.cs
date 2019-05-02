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

        // GET : Show Details of the product which the user has selected
        // (This GET request is coming from HomePageController)
        public ActionResult ProductDetail(string submitProduct)
        {
            //var userSelectedProduct = from k in _product.Products_174866_MiniProj
            //                          where k.ModelName == "Havells" || k.ModelName == "Philips" 
            //                          select k;


            //Products_174866_MiniProj userSelectedProd = TempData["userSelectedProduct"] as Products_174866_MiniProj;

                var product = _product.Products_174866_MiniProj.Where(x => x.ModelName == submitProduct).FirstOrDefault();
                return View(product);
            
        }
        //[HttpPost]
        //public ActionResult ProductDetail(Products_174866_MiniProj prod)
        //{
        //    return View();
        //}
    }
}