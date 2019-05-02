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
        DBEntities _products = new DBEntities();

        // GET: ProductRecommend
        public ActionResult Index(int submitProductId)
        {
            var displayRecommendedItemAsPerUserInput = _products.ProductsRecommend_174866_MiniProj.Where(x => x.ProductId == submitProductId).ToList();

            if (displayRecommendedItemAsPerUserInput != null)
            {
                return View(displayRecommendedItemAsPerUserInput);
            }

            return View();
        }
    }
}