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
    public class PrivateJournalController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: PrivateJournal
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId();
            Survivor survivor = db.Survivor.FirstOrDefault(s => s.ApplicationId == userId);
            return View(db.PrivateJournal.Where(c => c.SurvivorId == survivor.SurvivorId).ToList());
        }

        // GET: PrivateJournal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrivateJournal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrivateJournal/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "PrivateJournalId, PrivateJournalName, JournalEntry, SurvivorId")]PrivateJournal privateJournal)
        {
            try
            {
                // TODO: Add insert logic here
                var userId = User.Identity.GetUserId();
                Survivor survivor = db.Survivor.FirstOrDefault(s => s.ApplicationId == userId);
                privateJournal.SurvivorId = survivor.SurvivorId;
                db.PrivateJournal.Add(privateJournal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PrivateJournal/Edit/5
        public ActionResult Edit(int id)
        {
            PrivateJournal privateJournal = db.PrivateJournal.Find(id);
            return View(privateJournal);
        }

        // POST: PrivateJournal/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "PrivateJournalId, PrivateJournalName, JournalEntry, SurvivorId")]PrivateJournal privateJournal)
        {
            try
            {
                // TODO: Add update logic here
                db.Entry(privateJournal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PrivateJournal/Delete/5
        public ActionResult Delete(int? id)
        {
            PrivateJournal privateJournal = db.PrivateJournal.Find(id);
            return View(privateJournal);
        }

        // POST: PrivateJournal/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                PrivateJournal privateJournal = db.PrivateJournal.Find(id);
                db.PrivateJournal.Remove(privateJournal);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
