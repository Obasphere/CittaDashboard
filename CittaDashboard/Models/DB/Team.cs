//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CittaDashboard.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string All_contacts { get; set; }
        public string All_items { get; set; }
        public string All_invoices { get; set; }
        public string All_opportunities { get; set; }
        public string Unpaid_invoices { get; set; }
        public string Paid_invoices { get; set; }
        public string Lost_opportunities { get; set; }
        public string Won_opportunities { get; set; }
        public string New_opportunities { get; set; }
        public string Undeposited_funds { get; set; }
        public string Deposited_funds { get; set; }
        public Nullable<System.DateTime> Created_at { get; set; }
        public Nullable<System.DateTime> Updated_at { get; set; }
    }
}
