//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Categories_174866_MiniProj
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Categories_174866_MiniProj()
        {
            this.Products_174866_MiniProj = new HashSet<Products_174866_MiniProj>();
            this.ProductsRecommend_174866_MiniProj = new HashSet<ProductsRecommend_174866_MiniProj>();
        }
    
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products_174866_MiniProj> Products_174866_MiniProj { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductsRecommend_174866_MiniProj> ProductsRecommend_174866_MiniProj { get; set; }
    }
}
