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
    
    public partial class PER_NBT_TNM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PER_NBT_TNM()
        {
            this.PER_NBT_VRD_TNM = new HashSet<PER_NBT_VRD_TNM>();
        }
    
        public int NBT_NO { get; set; }
        public string NBT_ADI { get; set; }
        public Nullable<int> KRM_KODU { get; set; }
        public string ACIKLAMA { get; set; }
        public string IMZA_PER_AD_SOYAD1 { get; set; }
        public string IMZA_PER_UNVAN1 { get; set; }
        public string IMZA_PER_GRV1 { get; set; }
        public string IMZA_PER_AD_SOYAD2 { get; set; }
        public string IMZA_PER_UNVAN2 { get; set; }
        public string IMZA_PER_GRV2 { get; set; }
        public string IMZA_PER_AD_SOYAD3 { get; set; }
        public string IMZA_PER_UNVAN3 { get; set; }
        public string IMZA_PER_GRV3 { get; set; }
        public bool S112_GONDERILSIN { get; set; }
        public string S112_BOLUM_ID { get; set; }
    
        public virtual PER_KRM_TNM PER_KRM_TNM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PER_NBT_VRD_TNM> PER_NBT_VRD_TNM { get; set; }
    }
}
