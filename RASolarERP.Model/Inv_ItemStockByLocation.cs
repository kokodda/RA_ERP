//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RASolarERP.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inv_ItemStockByLocation
    {
        public Inv_ItemStockByLocation()
        {
            this.Fix_EmployeeWiseFixedAssetsAllocation = new HashSet<Fix_EmployeeWiseFixedAssetsAllocation>();
            this.Inv_ItemStockWithSerialNoByLocation = new HashSet<Inv_ItemStockWithSerialNoByLocation>();
        }
    
        public byte StoreLocation { get; set; }
        public string LocationCode { get; set; }
        public string ItemCode { get; set; }
        public double AvailableQuantity { get; set; }
        public double SerialQuantity { get; set; }
        public System.DateTime LastUpdateOn { get; set; }
        public double QuantityUnderAuditObservation { get; set; }
    
        public virtual Common_LocationInfo Common_LocationInfo { get; set; }
        public virtual Inv_StoreLocation Inv_StoreLocation { get; set; }
        public virtual ICollection<Fix_EmployeeWiseFixedAssetsAllocation> Fix_EmployeeWiseFixedAssetsAllocation { get; set; }
        public virtual ICollection<Inv_ItemStockWithSerialNoByLocation> Inv_ItemStockWithSerialNoByLocation { get; set; }
    }
}
