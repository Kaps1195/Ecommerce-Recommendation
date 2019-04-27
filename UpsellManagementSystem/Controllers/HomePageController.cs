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
        DbEntities _products = new DbEntities();
        // GET: HomePage
        public ActionResult Index(Products_174866_MiniProj products)
        {
            
            var displayAllItems = _products.Products_174866_MiniProj.ToList();

            if (displayAllItems != null)
            {
                return View(displayAllItems);
            }
            
            return View();
        }

        [HttpPost]
        public ActionResult Index(string ModelName)
        {
            var searchModelName = from k in _products.Products_174866_MiniProj.ToList()
                                       where k.ModelName == ModelName
                                       select k;
            return View(searchModelName);
        }
        
    }
}