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
    
    public partial class PER_ODUL
    {
        public int PER_ID { get; set; }
        public int ODUL_KODU { get; set; }
        public System.DateTime ODUL_TRH { get; set; }
        public int ODUL_ID { get; set; }
    
        public virtual PER_KIMLIK PER_KIMLIK { get; set; }
        public virtual PER_ODUL_TNM PER_ODUL_TNM { get; set; }
    }
}