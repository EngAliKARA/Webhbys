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
    
    public partial class PER_MSLK_FLYT_DETAY_TNM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PER_MSLK_FLYT_DETAY_TNM()
        {
            this.PER_MSLK_FLYT = new HashSet<PER_MSLK_FLYT>();
        }
    
        public int MSLK_FLYT_DETAY_KODU { get; set; }
        public string MSLK_FLYT_DETAY_ADI { get; set; }
        public int MSLK_FLYT_KODU { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PER_MSLK_FLYT> PER_MSLK_FLYT { get; set; }
        public virtual PER_MSLK_FLYT_TNM PER_MSLK_FLYT_TNM { get; set; }
    }
}
