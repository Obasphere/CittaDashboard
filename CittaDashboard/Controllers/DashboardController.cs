using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CittaDashboard.Models.DB;

namespace CittaDashboard.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        Entities DB = new Entities();
        
        public ActionResult Dashboard()
        {
            var contactCount = DB.Contacts.Count();
            ViewBag.contactCount = contactCount;

            var itemCount = DB.Items.Count();
            ViewBag.itemCount = itemCount;

            var invoiceCount = DB.Invoices.Count();
            ViewBag.invoiceCount = invoiceCount;

            var unpaid_invoiceCount = DB.Invoices.Where(e=> e.Status == "sent").Count();
            ViewBag.unpaid_invoiceCount = unpaid_invoiceCount;

            var paid_invoiceCount = DB.Invoices.Where(e => e.Status == "paid").Count();
            ViewBag.paid_invoiceCount = paid_invoiceCount;

            var opportunityCount = DB.Opportunities.Count();
            ViewBag.opportunityCount = opportunityCount;

            var lost_opportunityCount = DB.Opportunities.Where(e => e.Status == "lost").Count();
            ViewBag.lost_opportunityCount = lost_opportunityCount;

            var won_opportunityCount = DB.Opportunities.Where(e => e.Status == "won").Count();
            ViewBag.won_opportunityCount = won_opportunityCount;

            var new_opportunityCount = DB.Opportunities.Where(e => e.Status == "new").Count();
            ViewBag.new_opportunityCount = new_opportunityCount;

            var undeposited_fundsCount = DB.Payments.Where(e => e.Status == "undeposited").Count();
            ViewBag.undeposited_fundsCount = undeposited_fundsCount;

            var deposited_fundsCount = DB.Payments.Where(e => e.Status == "deposited").Count();
            ViewBag.deposited_fundsCount = deposited_fundsCount;
            
            return View();
        }
    }
}