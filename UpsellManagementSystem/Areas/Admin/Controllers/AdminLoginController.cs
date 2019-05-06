using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UpsellManagementSystem.Models;

namespace UpsellManagementSystem.Areas.Admin.Controllers
{
    public class AdminLoginController : Controller
    {
        // GET: Admin/AdminLogin
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AdminLogin(Admin_174866_MiniProj objAdmin)
        {
            if (ModelState.IsValid)
            {
                using (DBEntities db = new DBEntities())
                {
                    var obj = db.Admin_174866_MiniProj.Where(a => a.AdminEmail.Equals(objAdmin.AdminEmail) && a.AdminPwd.Equals(objAdmin.AdminPwd)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["AdminEmail"] = obj.AdminEmail.ToString();
                        return RedirectToAction("DisplayProducts", "Display");
                    }
                }
            }
            return View(objAdmin);
        }

        public ActionResult AdminLogout()
        {
            Session.Clear();
            return RedirectToAction("AdminLogin", "AdminLogin");
        }
    }
}