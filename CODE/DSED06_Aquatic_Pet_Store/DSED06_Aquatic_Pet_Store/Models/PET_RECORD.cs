//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DSED06_Aquatic_Pet_Store.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PET_RECORD
    {
        public int ID_PK { get; set; }
        public int PET_FK { get; set; }
        public Nullable<int> SIZE_FK { get; set; }
        public string CODE { get; set; }
        public string DESCRIPTION { get; set; }
    
        public virtual PET_INFO PET_INFO { get; set; }
        public virtual PET_SIZE PET_SIZE { get; set; }
        public virtual RECORD_PACKING RECORD_PACKING { get; set; }
    }
}
