//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RASolarAMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Common_ProjectInfo
    {
        public Common_ProjectInfo()
        {
            this.Acc_FinalTransMaster = new HashSet<Acc_FinalTransMaster>();
            this.Acc_LocationWiseDailySummary = new HashSet<Acc_LocationWiseDailySummary>();
        }
    
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string Project_Status { get; set; }
        public string Prog_Code { get; set; }
        public byte Status { get; set; }
        public Nullable<System.DateTime> EntryTime { get; set; }
    
        public virtual ICollection<Acc_FinalTransMaster> Acc_FinalTransMaster { get; set; }
        public virtual ICollection<Acc_LocationWiseDailySummary> Acc_LocationWiseDailySummary { get; set; }
    }
}
