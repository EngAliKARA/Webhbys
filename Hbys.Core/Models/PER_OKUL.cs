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
    
    public partial class PER_OKUL
    {
        public int PER_ID { get; set; }
        public string OKUL_TUR_KODU { get; set; }
        public int OKUL_KODU { get; set; }
        public int TAHSIL_ID { get; set; }
        public Nullable<int> FKLT_KODU { get; set; }
        public Nullable<int> BLM_KODU { get; set; }
        public Nullable<System.DateTime> BTS_TRH { get; set; }
        public Nullable<System.DateTime> BSL_TRH { get; set; }
        public string DIPLOMA_NO { get; set; }
        public string DIPLOMA_NOTU { get; set; }
    
        public virtual PER_KIMLIK PER_KIMLIK { get; set; }
        public virtual PER_OKUL_FKLT_BLM_TNM PER_OKUL_FKLT_BLM_TNM { get; set; }
        public virtual PER_OKUL_FKLT_TNM PER_OKUL_FKLT_TNM { get; set; }
        public virtual PER_OKUL_TNM PER_OKUL_TNM { get; set; }
        public virtual PER_OKUL_TUR_TNM PER_OKUL_TUR_TNM { get; set; }
    }
}