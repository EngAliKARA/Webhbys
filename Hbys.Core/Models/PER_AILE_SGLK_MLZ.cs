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
    
    public partial class PER_AILE_SGLK_MLZ
    {
        public int MLZ_KODU { get; set; }
        public System.DateTime BELGE_TRH { get; set; }
        public string BELGE_NO { get; set; }
        public Nullable<int> SURE { get; set; }
        public string SURE_KODU { get; set; }
        public Nullable<System.DateTime> TKRR_ALM_TRH { get; set; }
        public string ACIKLAMA { get; set; }
        public int YKN_PER_ID { get; set; }
    
        public virtual PER_AILE PER_AILE { get; set; }
        public virtual PER_AILE PER_AILE1 { get; set; }
        public virtual PER_SGLK_MLZ_TNM PER_SGLK_MLZ_TNM { get; set; }
        public virtual PER_SGLK_MLZ_TNM PER_SGLK_MLZ_TNM1 { get; set; }
    }
}
