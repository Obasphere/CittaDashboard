using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;
using System.Collections;
using CittaDashboard.Models.DB;

namespace CittaDashboard.Controllers
{
    public class TeamsController : Controller
    {
        private Entities DB = new Entities();
        Team team = new Team();

        // GET: Teams
        public ActionResult Index()
        {
            return View(DB.Teams.ToList());
        }

        // GET: Teams/DetailsCard/5
        public ActionResult DetailsCard(Int32 id)
        {
            team = DB.Teams.Find(id);

            ViewBag.Name = team.Name;
            ViewBag.All_contacts = team.All_contacts;
            ViewBag.All_items = team.All_items;
            ViewBag.All_invoices = team.All_invoices;
            ViewBag.All_opportunities = team.All_opportunities;
            ViewBag.Unpaid_invoices = team.Unpaid_invoices;
            ViewBag.Paid_invoices = team.Paid_invoices;
            ViewBag.Lost_opportunities = team.Lost_opportunities;
            ViewBag.Won_opportunities = team.Won_opportunities;
            ViewBag.New_opportunities = team.New_opportunities;
            ViewBag.Undeposited_funds = team.Undeposited_funds;
            ViewBag.Deposited_funds = team.Deposited_funds;
            
            return View(DB.Teams.ToList());
        }

        // GET: Teams/DetailsChart/5
        public ActionResult DetailsChart(Int32 id)
        {
            team = DB.Teams.Find(id);

            ViewBag.Name = team.Name;
            ViewBag.All_contacts = team.All_contacts;
            ViewBag.All_items = team.All_items;
            ViewBag.All_invoices = team.All_invoices;
            ViewBag.All_opportunities = team.All_opportunities;
            ViewBag.Unpaid_invoices = team.Unpaid_invoices;
            ViewBag.Paid_invoices = team.Paid_invoices;
            ViewBag.Lost_opportunities = team.Lost_opportunities;
            ViewBag.Won_opportunities = team.Won_opportunities;
            ViewBag.New_opportunities = team.New_opportunities;
            ViewBag.Undeposited_funds = team.Undeposited_funds;
            ViewBag.Deposited_funds = team.Deposited_funds;

            return View(DB.Teams.ToList());
        }

        // GET: Chart
        public ActionResult CharterColumn()
        {
            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();

            var results = (from c in DB.Invoices select c);
            results.ToList().ForEach(rs => xValue.Add(rs.Issue_date));
            results.ToList().ForEach(rs => yValue.Add(rs.Due_date));

            new Chart(width: 800, height: 400, theme: ChartTheme.Blue)
            .AddTitle("Chart for All Invoices [Issue Date against Due Date]")
            .AddSeries("Default", chartType: "Column", xValue: xValue, yValues: yValue)
            .AddLegend("Title")
            .Write("bmp");

            return null;
        }

        // GET: Teams/Create
        public ActionResult Create()
        {
            var contactCount = DB.Contacts.Count();
            ViewBag.contactCount = contactCount;

            var itemCount = DB.Items.Count();
            ViewBag.itemCount = itemCount;

            var invoiceCount = DB.Invoices.Count();
            ViewBag.invoiceCount = invoiceCount;

            var unpaid_invoiceCount = DB.Invoices.Where(e => e.Status == "sent").Count();
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

        // POST: Teams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,All_contacts,All_items,All_invoices,All_opportunities,Unpaid_invoices,Paid_invoices,Lost_opportunities,Won_opportunities,New_opportunities,Undeposited_funds,Deposited_funds,Created_at,Updated_at")] Team team)
        {
            if (ModelState.IsValid)
            {
                DB.Entry(team).State = EntityState.Added;
                DB.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(team);
        }

        // GET: Teams/Edit/5
        public ActionResult Edit(Int32 id)
        {
            Team team = DB.Teams.Find(id);

            ViewBag.Name = team.Name;
            ViewBag.All_contacts = team.All_contacts;
            ViewBag.All_items = team.All_items;
            ViewBag.All_invoices = team.All_invoices;
            ViewBag.All_opportunities = team.All_opportunities;
            ViewBag.Unpaid_invoices = team.Unpaid_invoices;
            ViewBag.Paid_invoices = team.Paid_invoices;
            ViewBag.Lost_opportunities = team.Lost_opportunities;
            ViewBag.Won_opportunities = team.Won_opportunities;
            ViewBag.New_opportunities = team.New_opportunities;
            ViewBag.Undeposited_funds = team.Undeposited_funds;
            ViewBag.Deposited_funds = team.Deposited_funds;

            var contactCount = DB.Contacts.Count();
            ViewBag.contactCount = contactCount;

            var itemCount = DB.Items.Count();
            ViewBag.itemCount = itemCount;

            var invoiceCount = DB.Invoices.Count();
            ViewBag.invoiceCount = invoiceCount;

            var unpaid_invoiceCount = DB.Invoices.Where(e => e.Status == "sent").Count();
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

            return View(team);
        }

        // POST: Teams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,All_contacts,All_items,All_invoices,All_opportunities,Unpaid_invoices,Paid_invoices,Lost_opportunities,Won_opportunities,New_opportunities,Undeposited_funds,Deposited_funds,Created_at,Updated_at")] Team team)
        {
            if (ModelState.IsValid)
            {
                DB.Entry(team).State = EntityState.Modified;
                DB.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(team);
        }

        // GET: Teams/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            team = DB.Teams.Find(id);
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
        }

        // POST: Teams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            team = DB.Teams.Find(id);
            DB.Teams.Remove(team);
            DB.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                DB.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
