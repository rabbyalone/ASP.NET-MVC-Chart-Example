using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AJAX_MVC4_APP.Models;
using System.Web.Helpers;

namespace AJAX_MVC4_APP.Controllers
{
    public class prodController : Controller
    {
        private AJAX_MVC4_APPContext db = new AJAX_MVC4_APPContext();

        //
        // GET: /prod/

        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        //
        // GET: /prod/Details/5

        public PartialViewResult prodInfo()
        {

           
            string id = Request.Form["txtCode"];
            var data = db.Products.Where(d => d.ID == id).FirstOrDefault();
            System.Threading.Thread.Sleep(5000);

            return PartialView("_Details", data);
        }

        
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}