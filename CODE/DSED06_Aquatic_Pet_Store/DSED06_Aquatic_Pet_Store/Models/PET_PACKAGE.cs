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
    
    public partial class PET_PACKAGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PET_PACKAGE()
        {
            this.RECORD_PACKAGE = new HashSet<RECORD_PACKAGE>();
        }
    
        public int ID_PK { get; set; }
        public string DESCRIPTION { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RECORD_PACKAGE> RECORD_PACKAGE { get; set; }
    }
}
