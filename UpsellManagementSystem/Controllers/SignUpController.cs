using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UpsellManagementSystem.Models;

namespace UpsellManagementSystem.Controllers
{
    public class SignUpController : Controller
    {
        public ActionResult CreateNewCustomer()
        {
            return View();
        }

        // GET: SignUp
        [HttpPost]
        public ActionResult CreateNewCustomer(Customers_174866_MiniProj newCustomer)
        {
            ProjectEntitiesUpdated db = new ProjectEntitiesUpdated();
            db.Customers_174866_MiniProj.Add(newCustomer);
            db.SaveChanges();
            return View(newCustomer);
        }
    }
}