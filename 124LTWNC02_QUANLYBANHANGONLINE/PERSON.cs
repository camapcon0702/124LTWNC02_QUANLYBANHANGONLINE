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
    
    public partial class PERSON
    {
        public decimal PARTY_ID { get; set; }
        public string CURRENT_LAST_NAME { get; set; }
        public string CURRENT_FIRST_NAME { get; set; }
        public string CURRENT_MIDDLE_NAME { get; set; }
        public string CURRENT_NICKNAME { get; set; }
        public Nullable<decimal> CURRENT_GENDER_TYPE_ID { get; set; }
        public Nullable<System.DateTime> BIRTH_DATE { get; set; }
        public string PEOPLE_ID_NUMBER { get; set; }
        public Nullable<System.DateTime> PEOPLE_ID_ISSUE_DATE { get; set; }
        public string PEOPLE_ID_ISSUE_PLACE { get; set; }
        public string CURRENT_PHONE_NUMBER { get; set; }
        public string CURRENT_EMAIL { get; set; }
        public string PERSON_IMAGE { get; set; }
    
        public virtual PARTY PARTY { get; set; }
    }
}
