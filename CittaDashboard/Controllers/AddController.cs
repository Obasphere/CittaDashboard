using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CittaDashboard.Models.DB;

namespace CittaDashboard.Controllers
{
    public class AddController : Controller
    {
        // GET: Add
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CittaDashboard.Models.DB.Contact model)
        {
            Entities entity = new Entities();
            model.Created_at = DateTime.Now;
            entity.Contacts.Add(model);
            entity.SaveChanges();
            return View();
        }
    }
}