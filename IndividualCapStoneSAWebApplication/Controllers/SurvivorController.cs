using IndividualCapStoneSAWebApplication.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio.AspNet.Common;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;

namespace IndividualCapStoneSAWebApplication.Controllers
{
    public class SurvivorController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Survivor
        public ActionResult Index()
        {
            string userId = User.Identity.GetUserId();
            return View(db.Survivor.Where(c => c.ApplicationId == userId).ToList());
        }

        // GET: Survivor/Details/5
        public ActionResult Details(int id)
        {
            Survivor survivor = db.Survivor.Find(id);
            return View(survivor);
        }

        // GET: Survivor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Survivor/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "SurvivorId,FirstName,LastName,EmergencyContactNumber,EmailAddress,ApplicationId")]Survivor survivor)
        {
            try
            {
                // TODO: Add insert logic here
                string userId = User.Identity.GetUserId();
                survivor.ApplicationId = userId;
                db.Survivor.Add(survivor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Survivor/Edit/5
        public ActionResult Edit(int id)
        {
            Survivor survivor = db.Survivor.Find(id);
            return View(survivor);
        }

        // POST: Survivor/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "SurvivorId,FirstName,LastName,EmergencyContactNumber,EmailAddress,ApplicationId, requestToBeSponsor")]Survivor survivor)
        {
            try
            {
                // TODO: Add update logic here
                db.Entry(survivor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Survivor/Delete/5
        public ActionResult Delete(int? id)
        {
            Survivor survivor = db.Survivor.Find(id);
            return View(survivor);
        }

        // POST: Survivor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                Survivor survivor = db.Survivor.Find(id);
                db.Survivor.Remove(survivor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult RequestSponsorship(int id)
        {
            Survivor survivor = db.Survivor.Find(id);
            return View(id);
        }

        [HttpPost]
        public ActionResult RequestSponsorship([Bind(Include = "requestToBeSponsor")] Survivor survivor)
        {
            db.Entry(survivor).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        
        public ActionResult PlacesToHelp()
        {
            
            return View(db.ContactInfo.ToList());
        }

        public ActionResult SendText()
        {
            return View();
        }

        public ActionResult InfoSites()
        {
            
            return View();
        }
        
        
    }
}
