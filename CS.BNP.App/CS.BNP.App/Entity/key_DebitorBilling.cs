//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CS.BNP.App.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class key_DebitorBilling
    {
        public int ID { get; set; }
        public int DebitorPeriodID { get; set; }
        public int BillingPeriodID { get; set; }
    
        public virtual mas_DebitorBillingPeriod mas_DebitorBillingPeriod { get; set; }
        public virtual tran_BillingPeriod tran_BillingPeriod { get; set; }
    }
}
