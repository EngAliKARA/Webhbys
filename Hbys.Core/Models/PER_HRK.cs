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
    
    public partial class PER_HRK
    {
        public int PER_ID { get; set; }
        public System.DateTime DEG_TRH { get; set; }
        public Nullable<int> ESKI_KDR { get; set; }
        public Nullable<int> ESKI_DRC { get; set; }
        public Nullable<int> ESKI_KDM { get; set; }
        public Nullable<decimal> ESKI_KDM_YILI { get; set; }
        public Nullable<System.DateTime> SONRAKI_TERFI_TRH { get; set; }
        public Nullable<int> YENI_KDR { get; set; }
        public Nullable<int> YENI_DRC { get; set; }
        public Nullable<int> YENI_KDM { get; set; }
        public Nullable<int> YENI_KDM_YILI { get; set; }
        public Nullable<int> ESKI_UNVAN_KODU { get; set; }
        public Nullable<int> YENI_UNVAN_KODU { get; set; }
        public Nullable<System.DateTime> YENI_BSLM_TRH { get; set; }
        public Nullable<System.DateTime> ESKI_AYRLS_TRH { get; set; }
        public Nullable<System.DateTime> KYT_TRH { get; set; }
        public string KYT_NO { get; set; }
        public string TKLF_EDEN_ADI { get; set; }
        public string TKLF_EDEN_SOYADI { get; set; }
        public string TKLF_EDEN_GRV { get; set; }
        public string ONAY_PER_ADI { get; set; }
        public string ONAY_PER_SOYADI { get; set; }
        public string ONAY_PER_GRV { get; set; }
        public string ADAY_DRM_KODU { get; set; }
        public Nullable<int> ADAY_SURE { get; set; }
        public string ASK_DRM_KODU { get; set; }
        public int TERFID { get; set; }
    
        public virtual PER_ADAY_DRM_TNM PER_ADAY_DRM_TNM { get; set; }
        public virtual PER_UNVAN_TNM PER_UNVAN_TNM { get; set; }
        public virtual PER_KIMLIK PER_KIMLIK { get; set; }
        public virtual PER_UNVAN_TNM PER_UNVAN_TNM1 { get; set; }
    }
}