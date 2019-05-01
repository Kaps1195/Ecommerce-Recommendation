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
        public ProjectEntitiesUpdated _product = new ProjectEntitiesUpdated();

        // GET : Show Details of the product which the user has selected
        // (This GET request is coming from HomePageController)
        public ActionResult ProductDetail()
        {
            //var userSelectedProduct = from k in _product.Products_174866_MiniProj
            //                          where k.ModelName == "Havells" || k.ModelName == "Philips" 
            //                          select k;


            //Products_174866_MiniProj userSelectedProd = TempData["userSelectedProduct"] as Products_174866_MiniProj;

                return View();
            
        }
    }
}