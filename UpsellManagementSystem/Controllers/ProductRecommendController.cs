using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UpsellManagementSystem.Models;

namespace UpsellManagementSystem.Controllers
{
    public class ProductRecommendController : Controller
    {
        ProjectEntitiesUpdated _products = new ProjectEntitiesUpdated();

        // GET: ProductRecommend
        public ActionResult Index(ProductsRecommend_174866_MiniProj recommendProd)
        {
            var displayAllItems = _products.ProductsRecommend_174866_MiniProj.ToList();

            if (displayAllItems != null)
            {
                return View(displayAllItems);
            }

            return View();
        }
    }
}