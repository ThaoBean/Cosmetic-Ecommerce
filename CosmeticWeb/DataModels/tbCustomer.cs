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
    
    public partial class tbCustomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbCustomer()
        {
            this.tbCarts = new HashSet<tbCart>();
            this.tbOrders = new HashSet<tbOrder>();
            this.tbReviewers = new HashSet<tbReviewer>();
        }
    
        public long Id_Customer { get; set; }
        public string Name_Customer { get; set; }
        public string Email_Customer { get; set; }
        public string Addr_Customer { get; set; }
        public string Phone_Customer { get; set; }
        public string Password_Customer { get; set; }
        public Nullable<System.DateTime> Date_Created { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbCart> tbCarts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbOrder> tbOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbReviewer> tbReviewers { get; set; }
    }
}
