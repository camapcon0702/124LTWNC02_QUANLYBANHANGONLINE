//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _124LTWNC02_QUANLYBANHANGONLINE
{
    using System;
    using System.Collections.Generic;
    
    public partial class GENDER
    {
        public decimal PARTY_ID { get; set; }
        public decimal GENDER_TYPE_ID { get; set; }
        public System.DateTime FROM_DATE { get; set; }
        public Nullable<System.DateTime> THRU_DATE { get; set; }
    
        public virtual GENDER_TYPE GENDER_TYPE { get; set; }
    }
}
