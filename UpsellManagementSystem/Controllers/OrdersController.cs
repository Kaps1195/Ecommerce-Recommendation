using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UpsellManagementSystem.Models;

namespace UpsellManagementSystem.Controllers
{
    public class OrdersController : Controller
    {
        public DBEntities _product = new DBEntities();

        public ActionResult Orders(int? userSelectedProdid)
        {

            Products_174866_MiniProj prod = _product.Products_174866_MiniProj.Find(userSelectedProdid);

            ShoppingCart_174866_MiniProj addValue = _product.ShoppingCart_174866_MiniProj.Where(x => x.productId == userSelectedProdid).FirstOrDefault(); ;
            if(addValue == null)
            {
                ShoppingCart_174866_MiniProj addValue1 = new ShoppingCart_174866_MiniProj();
                addValue1.cartImageUrl = prod.imageUrl;
                addValue1.cartModelName = prod.ModelName;
                addValue1.productPrice = Convert.ToInt32(prod.UnitCost);
                _product.ShoppingCart_174866_MiniProj.Add(addValue1);
                _product.SaveChanges();
                return View(addValue1);
            }
            else
            {
                return View(prod);
            }
            
        }
    }
}