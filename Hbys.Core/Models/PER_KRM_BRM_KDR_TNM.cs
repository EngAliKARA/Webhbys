//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hbys.Core.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PER_KRM_BRM_KDR_TNM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PER_KRM_BRM_KDR_TNM()
        {
            this.PER_KIMLIK = new HashSet<PER_KIMLIK>();
            this.PER_KRM_BRM_KDR_YER = new HashSet<PER_KRM_BRM_KDR_YER>();
        }
    
        public int KRM_BRM_KDR_KODU { get; set; }
        public string KRM_BRM_KDR_ADI { get; set; }
        public int KDR_STNDRT { get; set; }
        public int KRM_BRM_KODU { get; set; }
        public string DRM_KODU { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PER_KIMLIK> PER_KIMLIK { get; set; }
        public virtual PER_KRM_BRM_TNM PER_KRM_BRM_TNM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PER_KRM_BRM_KDR_YER> PER_KRM_BRM_KDR_YER { get; set; }
    }
}
