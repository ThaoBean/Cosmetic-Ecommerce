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
    
    public partial class tbOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbOrder()
        {
            this.tbOrderDetails = new HashSet<tbOrderDetail>();
        }
    
        public long Id_Order { get; set; }
        public Nullable<long> Id_Customer { get; set; }
        public string Shipping_Addr { get; set; }
        public string Phone_Reciever { get; set; }
        public string Name_Reciever { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<decimal> Price_Total { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual tbCustomer tbCustomer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbOrderDetail> tbOrderDetails { get; set; }
    }
}