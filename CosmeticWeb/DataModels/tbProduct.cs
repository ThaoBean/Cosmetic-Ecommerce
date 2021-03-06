//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbProduct()
        {
            this.tbCarts = new HashSet<tbCart>();
            this.tbOrderDetails = new HashSet<tbOrderDetail>();
            this.tbReviewers = new HashSet<tbReviewer>();
        }
    
        public long Id_Product { get; set; }
        public Nullable<long> Id_Brand { get; set; }
        public Nullable<long> Id_Nation { get; set; }
        public Nullable<long> Id_Category { get; set; }
        public string Name_Product { get; set; }
        public string Description_Product { get; set; }
        public string Detail_Product { get; set; }
        public string Image_Product { get; set; }
        public Nullable<int> Quality_Product { get; set; }
        public Nullable<decimal> Price_Product { get; set; }
        public Nullable<decimal> Sale_Product { get; set; }
        public Nullable<bool> Hot_Product { get; set; }
        public Nullable<int> Rate_Total_Product { get; set; }
    
        public virtual tbBrand tbBrand { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCart> tbCarts { get; set; }
        public virtual tbCategory tbCategory { get; set; }
        public virtual tbNation tbNation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbOrderDetail> tbOrderDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbReviewer> tbReviewers { get; set; }
    }
}
