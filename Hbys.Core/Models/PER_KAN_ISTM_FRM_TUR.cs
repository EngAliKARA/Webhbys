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
    
    public partial class PER_KAN_ISTM_FRM_TUR
    {
        public int KAN_ISTM_FRM_NO { get; set; }
        public int KAN_ISTM_TUR_KODU { get; set; }
        public int MKTR { get; set; }
    
        public virtual PER_KAN_ISTM_FRM PER_KAN_ISTM_FRM { get; set; }
        public virtual PER_KAN_ISTM_TUR_TNM PER_KAN_ISTM_TUR_TNM { get; set; }
    }
}
