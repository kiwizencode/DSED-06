//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSED06_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AQUATIC_PET
    {
        public int ID_PK { get; set; }
        public string COMMON { get; set; }
        public string SCIENTIFIC { get; set; }
        public int GROUP_FK { get; set; }
    
        public virtual AQUATIC_GROUP AQUATIC_GROUP { get; set; }
    }
}
