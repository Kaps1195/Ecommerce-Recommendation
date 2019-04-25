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
            DbEntities db = new DbEntities();
            var displayOnlyFirstThreeItems = db.Products_174866_MiniProj.Take(3);

            if (displayOnlyFirstThreeItems != null)
            {

            }

            return View();
        }
    }
}