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
    
    public partial class PER_OKUL_FKLT_TUR_TNM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PER_OKUL_FKLT_TUR_TNM()
        {
            this.PER_OKUL_FKLT_BLM_TUR_TNM = new HashSet<PER_OKUL_FKLT_BLM_TUR_TNM>();
            this.PER_OKUL_FKLT_TNM = new HashSet<PER_OKUL_FKLT_TNM>();
        }
    
        public int FKLT_TUR_KODU { get; set; }
        public string FKLT_TUR_ADI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PER_OKUL_FKLT_BLM_TUR_TNM> PER_OKUL_FKLT_BLM_TUR_TNM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PER_OKUL_FKLT_TNM> PER_OKUL_FKLT_TNM { get; set; }
    }
}
