﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UpsellManagementSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBEntities : DbContext
    {
        public DBEntities()
            : base("name=DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categories_174866_MiniProj> Categories_174866_MiniProj { get; set; }
        public virtual DbSet<Customers_174866_MiniProj> Customers_174866_MiniProj { get; set; }
        public virtual DbSet<Orders_174866_MiniProj> Orders_174866_MiniProj { get; set; }
        public virtual DbSet<Products_174866_MiniProj> Products_174866_MiniProj { get; set; }
        public virtual DbSet<ProductsRecommend_174866_MiniProj> ProductsRecommend_174866_MiniProj { get; set; }
        public virtual DbSet<SalesTax_174866_MiniProj> SalesTax_174866_MiniProj { get; set; }
        public virtual DbSet<Admin_174866_MiniProj> Admin_174866_MiniProj { get; set; }
        public virtual DbSet<ShoppingCart_174866_MiniProj> ShoppingCart_174866_MiniProj { get; set; }
    }
}
