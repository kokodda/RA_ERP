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
    
    public partial class Sal_ModeOfPayment
    {
        public Sal_ModeOfPayment()
        {
            this.Sal_PackageMaster = new HashSet<Sal_PackageMaster>();
            this.Sal_Validation_CustomerTypeVsModeOfPayment = new HashSet<Sal_Validation_CustomerTypeVsModeOfPayment>();
            this.Sal_Validation_ModeOfPaymentVsPackage = new HashSet<Sal_Validation_ModeOfPaymentVsPackage>();
            this.Sal_Validation_ModeOfPaymentWiseDiscountPolicy = new HashSet<Sal_Validation_ModeOfPaymentWiseDiscountPolicy>();
        }
    
        public string ModeOfPaymentID { get; set; }
        public string Description { get; set; }
        public byte ShowingOrder { get; set; }
        public byte Status { get; set; }
        public Nullable<byte> NumberOfInstallment { get; set; }
    
        public virtual ICollection<Sal_PackageMaster> Sal_PackageMaster { get; set; }
        public virtual ICollection<Sal_Validation_CustomerTypeVsModeOfPayment> Sal_Validation_CustomerTypeVsModeOfPayment { get; set; }
        public virtual ICollection<Sal_Validation_ModeOfPaymentVsPackage> Sal_Validation_ModeOfPaymentVsPackage { get; set; }
        public virtual ICollection<Sal_Validation_ModeOfPaymentWiseDiscountPolicy> Sal_Validation_ModeOfPaymentWiseDiscountPolicy { get; set; }
    }
}
