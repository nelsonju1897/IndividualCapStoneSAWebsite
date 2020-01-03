using IndividualCapStoneSAWebApplication.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndividualCapStoneSAWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            //string userId = User.Identity.GetUserId();
            //var survivor = db.Survivor.Where(s => s.ApplicationId == userId);
            //var admin = db.Admin.Where(a => a.ApplicationId == userId);
            if (this.User.IsInRole("Admin"))
            {
                return RedirectToAction("Index", "Admin");
            }
            if (this.User.IsInRole("Survivor"))
            {
                return RedirectToAction("Index", "Survivor");
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}