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
    
    public partial class InvAvailableItemInALocation
    {
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string CapacityID { get; set; }
        public string ItemCapacity { get; set; }
        public string ItemModelID { get; set; }
        public string ItemModel { get; set; }
        public bool IsItASerializableItem { get; set; }
        public double AvailableQuantity { get; set; }
        public Nullable<short> SerialQuantity { get; set; }
        public double QuantityUnderAuditObservation { get; set; }
    }
}
