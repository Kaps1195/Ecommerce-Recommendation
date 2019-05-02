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
                using (DBEntities db = new DBEntities())
                {
                    var obj = db.Customers_174866_MiniProj.Where(a => a.Email.Equals(objUser.Email) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["Email"] = obj.Email.ToString();
                        return RedirectToAction("Index","HomePage");
                    }
                }
            }
            return View(objUser);
        }
    }
}