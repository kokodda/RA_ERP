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
    
    public partial class Inv_ItemTransactionDetailsWithSerialNo
    {
        public Inv_ItemTransactionDetailsWithSerialNo()
        {
            this.Inv_ItemNItemCategoryWithSerialNoMaster = new HashSet<Inv_ItemNItemCategoryWithSerialNoMaster>();
        }
    
        public byte StoreLocation { get; set; }
        public string YearMonth { get; set; }
        public string LocationCode { get; set; }
        public string ItemCode { get; set; }
        public string MRROrChallanSeqNo { get; set; }
        public string ReceiveOrIssue { get; set; }
        public string ItemSerialNo { get; set; }
        public byte ItemConditionOrStatus { get; set; }
        public string RefMRRSeqNo { get; set; }
        public string RefChallanSeqNo { get; set; }
        public Nullable<byte> RefMRROrChallanCompSeqNo { get; set; }
    
        public virtual Inv_ChallanDetailsWithSerialNo Inv_ChallanDetailsWithSerialNo { get; set; }
        public virtual Inv_ItemTransactionDetails Inv_ItemTransactionDetails { get; set; }
        public virtual Inv_MRRDetailsWithSerialNo Inv_MRRDetailsWithSerialNo { get; set; }
        public virtual ICollection<Inv_ItemNItemCategoryWithSerialNoMaster> Inv_ItemNItemCategoryWithSerialNoMaster { get; set; }
        public virtual Inv_ItemNItemCategoryWithSerialNoMaster Inv_ItemNItemCategoryWithSerialNoMaster1 { get; set; }
    }
}
