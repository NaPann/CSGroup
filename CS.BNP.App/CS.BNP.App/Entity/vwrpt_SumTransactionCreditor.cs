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
    
    public partial class vwrpt_SumTransactionCreditor
    {
        public long Inx { get; set; }
        public int BillingPeriodID { get; set; }
        public string BillingPeriodCode { get; set; }
        public System.DateTime BillingDateFrom { get; set; }
        public System.DateTime BillingDateTo { get; set; }
        public int BillingStatus { get; set; }
        public int CreditorID { get; set; }
        public string CreditorCode { get; set; }
        public string CreditorName { get; set; }
        public string CreditorAddress { get; set; }
        public string CreditorTel { get; set; }
        public string CreditorContact { get; set; }
        public int JobID { get; set; }
        public string JobCode { get; set; }
        public System.DateTime JobDateStart { get; set; }
        public string JobName { get; set; }
        public int DebtorID { get; set; }
        public string DebtorCode { get; set; }
        public string DebtorName { get; set; }
        public string DebtorAddress { get; set; }
        public string DebtorTel { get; set; }
        public string DebtorContact { get; set; }
        public decimal Budget { get; set; }
        public int ProductID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductUnit { get; set; }
        public decimal ProductPrice { get; set; }
        public Nullable<decimal> TranWeight { get; set; }
        public Nullable<decimal> TranBuyPrice { get; set; }
        public Nullable<decimal> TranDiscount { get; set; }
        public Nullable<decimal> TranVat { get; set; }
        public Nullable<decimal> TotalBeforeDiscount { get; set; }
        public Nullable<decimal> TotalBeforeVat { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public Nullable<int> TranUnitQuantity { get; set; }
        public Nullable<decimal> PrepaidTotalAmount { get; set; }
        public string REM { get; set; }
        public string TranUnit { get; set; }
        public string TranDetail { get; set; }
        public string TranDetailAmt { get; set; }
    }
}
