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
    
    public partial class InvItemInTransit
    {
        public string ChallanFromLocationName { get; set; }
        public string ChallanFromLocationCode { get; set; }
        public string ChallanToLocationCode { get; set; }
        public string ChallanToLocationName { get; set; }
        public System.DateTime ChallanDate { get; set; }
        public string ChallanSeqNo { get; set; }
        public Nullable<byte> StoreLocationCode { get; set; }
        public string StoreLocationName { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemModel { get; set; }
        public double DeliveryQuantity { get; set; }
        public double ReceiveQuantity { get; set; }
        public double InTransitQuantity { get; set; }
        public double DeliveryValue { get; set; }
        public double ReceiveValue { get; set; }
        public Nullable<double> InTransitValue { get; set; }
    }
}
