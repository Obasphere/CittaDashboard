using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CittaDashboard.Models.ViewModel
{
    public class ViewModel
    {
        public class Contact
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Invoice
        {
            public int Id { get; set; }
            public DateTime Issue_date { get; set; }
            public DateTime Due_date { get; set; }
            public string Status { get; set; }
        }

        public class Item
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Opportunity
        {
            public int Id { get; set; }
            public string Status { get; set; }
        }

        public class Payment
        {
            public int Id { get; set; }
            public DateTime Payment_date { get; set; }
            public string Status { get; set; }
        }

        public class Team
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
            public List<string> Teams { get; set; }
        }
    }
}