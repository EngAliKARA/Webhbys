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
    
    public partial class PER_KAN_ISTM_TUR_TNM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PER_KAN_ISTM_TUR_TNM()
        {
            this.PER_KAN_ISTM_FRM_TUR = new HashSet<PER_KAN_ISTM_FRM_TUR>();
        }
    
        public int KAN_ISTM_TUR_KODU { get; set; }
        public string KAN_ISTM_TUR_ADI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PER_KAN_ISTM_FRM_TUR> PER_KAN_ISTM_FRM_TUR { get; set; }
    }
}