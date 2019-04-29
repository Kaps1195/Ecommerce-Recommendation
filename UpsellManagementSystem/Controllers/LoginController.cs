using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UpsellManagementSystem.Models;

namespace UpsellManagementSystem.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Customers_174866_MiniProj objUser)
        {
            if (ModelState.IsValid)
            {
                using (ProjectEntitiesUpdated db = new ProjectEntitiesUpdated())
                {
                    var obj = db.Customers_174866_MiniProj.Where(a => a.FullName.Equals(objUser.FullName) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserName"] = obj.FullName.ToString();
                        return RedirectToAction("Index","HomePage");
                    }
                }
            }
            return View(objUser);
        }

        public ActionResult RedirectAfterLogin()
        {
            if (Session["UserName"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}