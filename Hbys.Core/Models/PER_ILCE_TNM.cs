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
    
    public partial class PER_ILCE_TNM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PER_ILCE_TNM()
        {
            this.PER_KIMLIK = new HashSet<PER_KIMLIK>();
        }
    
        public int ILCE_KODU { get; set; }
        public string ILCE_ADI { get; set; }
        public Nullable<int> IL_KODU { get; set; }
    
        public virtual PER_IL_TNM PER_IL_TNM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PER_KIMLIK> PER_KIMLIK { get; set; }
    }
}
