//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClothesWebNET.Models
{
    using System;
    using System.Collections.Generic;
    public class ProductDTODetail
    {
        public string idProduct { get; set; }
        public string type { get; set; }
        public string nameProduct { get; set; }
        public double price { get; set; }
        public string URLImage { get; set; }
        public int sizeM { get; set; }
        public int sizeL { get; set; }
        public int sizeXL { get; set; }

    }
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.DetailBIll = new HashSet<DetailBIll>();
            this.ImageProduct = new HashSet<ImageProduct>();
        }
    
        public string nameProduct { get; set; }
        public string idProduct { get; set; }
        public int sizeM { get; set; }
        public int sizeL { get; set; }
        public int sizeXL { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public string idType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailBIll> DetailBIll { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageProduct> ImageProduct { get; set; }
        public virtual Types Types { get; set; }
    }
}
