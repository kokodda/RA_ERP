//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RASolarHRMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hrm_ReligionInfo
    {
        public Hrm_ReligionInfo()
        {
            this.Hrm_EmployeeInfo = new HashSet<Hrm_EmployeeInfo>();
        }
    
        public string ReligionID { get; set; }
        public string ReligionName { get; set; }
        public Nullable<byte> SortingOrder { get; set; }
        public Nullable<byte> Status { get; set; }
    
        public virtual ICollection<Hrm_EmployeeInfo> Hrm_EmployeeInfo { get; set; }
    }
}
