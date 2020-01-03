using IndividualCapStoneSAWebApplication.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndividualCapStoneSAWebApplication.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin
        public ActionResult Index()
        {
            var sponsorRequests = db.Survivor.Where(s => s.requestToBeSponsor == true || s.isSponsor == true);
            return View(sponsorRequests);
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "AdminId, FirstName, LastName, EmailAddress, ApplicationId")]Admin admin)
        {
            try
            {
                // TODO: Add insert logic here
                string userId = User.Identity.GetUserId();
                admin.ApplicationId = userId;
                db.Admin.Add(admin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            Survivor survivor = db.Survivor.Where(s => s.SurvivorId == id).FirstOrDefault();
            return View(survivor);
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, [Bind(Include = "SurvivorId,FirstName,LastName,EmergencyContactNumber,EmailAddress,ApplicationId, requestToBeSponsor, isSponsor")]Survivor survivor)
        {
            try
            {
                // TODO: Add update logic here
                Survivor sponsorshipRequest = db.Survivor.Where(s => s.SurvivorId == id).FirstOrDefault();
                sponsorshipRequest.isSponsor = survivor.isSponsor;
                sponsorshipRequest.requestToBeSponsor = survivor.requestToBeSponsor;
                db.Entry(sponsorshipRequest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
