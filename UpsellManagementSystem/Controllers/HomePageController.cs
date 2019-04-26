using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UpsellManagementSystem.Models;

namespace UpsellManagementSystem.Controllers
{
    public class HomePageController : Controller
    {
        
        // GET: HomePage
        public ActionResult Index(Products_174866_MiniProj products)
        {
            DbEntities _products = new DbEntities();
            var displayAllItems = _products.Products_174866_MiniProj.ToList();

            if (displayAllItems != null)
            {
                return View(displayAllItems);
            }
            
            return View();
        }


        //public ActionResult Index(ProductsRecommend_174866_MiniProj products)
        //{
        //    DbEntities _products = new DbEntities();
        //    var displayAllItems = _products.Products_174866_MiniProj.ToList();

        //    if (displayAllItems != null)
        //    {
        //        return View(displayAllItems);
        //    }

        //    return View();
        //}
    }
}