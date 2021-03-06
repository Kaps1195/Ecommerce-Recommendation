﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UpsellManagementSystem.Models;

namespace UpsellManagementSystem.Areas.Admin.Controllers
{
    public class CreateController : Controller
    {
        DBEntities _product = new DBEntities();

        public ActionResult AddCategory()
        {
            return View();
        }

        // GET: Admin/Create/AddCategory
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCategory(Categories_174866_MiniProj newCategory)
        {
            _product.Categories_174866_MiniProj.Add(newCategory);
            _product.SaveChanges();
            return View(newCategory);
        }

        public ActionResult AddProduct()
        {
            TempData["CategoryList"] = new SelectList(GetCategoryList(),"Value"); 
            return View();
        }

        // List : To store Category List
        private List<SelectListItem> GetCategoryList()
        {
            return _product.Categories_174866_MiniProj.Select(e => new SelectListItem
            {
                Value = e.CategoryId.ToString()
            }).ToList();
        }

        // GET: Admin/Create/AddProduct
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddProduct(Products_174866_MiniProj newProduct)
        {
            _product.Products_174866_MiniProj.Add(newProduct);
            _product.SaveChanges();
            return View(newProduct);
        }

        public ActionResult AddRecommendProduct()
        {
            return View();
        }

        // GET: Admin/Create/AddRecommendProduct
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddRecommendProduct(ProductsRecommend_174866_MiniProj newRecProduct)
        {
            _product.ProductsRecommend_174866_MiniProj.Add(newRecProduct);
            _product.SaveChanges();
            return View(newRecProduct);
        }
    }
}