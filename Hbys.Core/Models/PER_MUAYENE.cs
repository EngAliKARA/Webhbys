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
    
    public partial class PER_MUAYENE
    {
        public int MUAYENE_ID { get; set; }
        public string MUAYENE_KODU { get; set; }
        public string KRM_ADI { get; set; }
        public string TCKIMLIK_NO { get; set; }
        public string MMR_ADI_SOYADI { get; set; }
        public string HST_ADI_SOYADI { get; set; }
        public string GRV_ADI { get; set; }
        public string KRM_SCL_NO { get; set; }
        public string KDR_DRC { get; set; }
        public string ADRES { get; set; }
        public string YTK_ADI_SOYADI { get; set; }
        public string YTK_UNVAN { get; set; }
        public Nullable<System.DateTime> KRM_KYT_TRH { get; set; }
        public Nullable<int> KRM_KYT_NO { get; set; }
        public int PER_ID { get; set; }
    
        public virtual PER_KIMLIK PER_KIMLIK { get; set; }
        public virtual PER_KIMLIK PER_KIMLIK1 { get; set; }
        public virtual PER_KIMLIK PER_KIMLIK2 { get; set; }
    }
}