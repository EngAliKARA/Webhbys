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
    
    public partial class PER_DIL_SNV
    {
        public int PER_ID { get; set; }
        public string DIL_KODU { get; set; }
        public string SNV_KODU { get; set; }
        public System.DateTime SNV_TRH { get; set; }
        public int NOTU { get; set; }
        public string DRC_KODU { get; set; }
        public string BELGE_TURU { get; set; }
        public Nullable<System.DateTime> BELGE_TRH { get; set; }
        public string BELGE_NO { get; set; }
        public string ACIKLAMA { get; set; }
        public int PDILID { get; set; }
    
        public virtual PER_DIL_TNM PER_DIL_TNM { get; set; }
        public virtual PER_KIMLIK PER_KIMLIK { get; set; }
        public virtual PER_SNV_TNM PER_SNV_TNM { get; set; }
    }
}