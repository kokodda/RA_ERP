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
    
    public partial class Common_RegionInfo
    {
        public Common_RegionInfo()
        {
            this.Common_UnitInfo = new HashSet<Common_UnitInfo>();
        }
    
        public string Reg_Code { get; set; }
        public string Reg_Name { get; set; }
        public string Zone_Code { get; set; }
        public string RM_CellNo { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime Modified { get; set; }
        public Nullable<byte> Status { get; set; }
    
        public virtual Common_LocationInfo Common_LocationInfo { get; set; }
        public virtual Common_ZoneInfo Common_ZoneInfo { get; set; }
        public virtual ICollection<Common_UnitInfo> Common_UnitInfo { get; set; }
    }
}
