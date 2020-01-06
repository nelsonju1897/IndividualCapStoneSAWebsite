using IndividualCapStoneSAWebApplication.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndividualCapStoneSAWebApplication.Controllers
{
    public class AssaultRecordController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: AssaultRecord
        public ActionResult Index()
        {
            return View(db.AssaultRecords.ToList());
        }

        // GET: AssaultRecord/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AssaultRecord/Create
        public ActionResult Create()
        {
            AssaultRecord assaultRecord = new AssaultRecord();
            var userId = User.Identity.GetUserId();
            Survivor survivor = db.Survivor.FirstOrDefault(s => s.ApplicationId == userId);
            assaultRecord.SurvivorId = survivor.SurvivorId;
            ViewBag.Relationships = new SelectList(db.AttackerRelationship.ToList(), "AttackerRelationshipId", "AttackerRelationshipName");
            ViewBag.AssaultTypes = new SelectList(db.AssaultType.ToList(), "AssaultTypeId", "AssaultTypeName");
            ViewBag.AlcoholAndOrDrugs = new SelectList(db.AlcoholAndOrDrugs.ToList(), "AlcoholAndOrDrugsId", "AlcoholAndOrDrugsName");
            ViewBag.AssaultLocation = new SelectList(db.AssaultLocation.ToList(), "AssaultLocationId", "AssaultLocationName");
            return View(assaultRecord);
        }

        // POST: AssaultRecord/Create
        [HttpPost]
        public ActionResult Create([Bind(Include ="AssaultRecordId, SurvivorId, AssaultLocationId, AssaultTypeId, AttackerRelationshipId, AlcoholAndOrDrugId")]AssaultRecord assaultRecord)
        {
            try
            {
                // TODO: Add insert logic here
                var userId = User.Identity.GetUserId();
                Survivor survivor = db.Survivor.FirstOrDefault(s => s.ApplicationId == userId);
                assaultRecord.SurvivorId = survivor.SurvivorId;
                db.AssaultRecords.Add(assaultRecord);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Relationships = new SelectList(db.AttackerRelationship.ToList(), "AttackerRelationshipId", "AttackerRelationshipName");
                ViewBag.AssaultTypes = new SelectList(db.AssaultType.ToList(), "AssaultTypeId", "AssaultTypeName");
                ViewBag.AlcoholAndOrDrugs = new SelectList(db.AlcoholAndOrDrugs.ToList(), "AlcoholAndOrDrugsId", "AlcoholAndOrDrugsName");
                ViewBag.AssaultLocation = new SelectList(db.AssaultLocation.ToList(), "AssaultLocationId", "AssaultLocationName");
                return View();
            }
        }

        // GET: AssaultRecord/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AssaultRecord/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AssaultRecord/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AssaultRecord/Delete/5
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

        public ActionResult AssaultLocation()
        {
            ViewBag.AssaultLocation = db.AssaultRecords.Where(l => l.AssaultLocationId == 1).ToList().Count();
            ViewBag.AssaultLocation2 = db.AssaultRecords.Where(l => l.AssaultLocationId == 2).ToList().Count();
            ViewBag.AssaultLocation3 = db.AssaultRecords.Where(l => l.AssaultLocationId == 3).ToList().Count();
            ViewBag.AssaultLocation4 = db.AssaultRecords.Where(l => l.AssaultLocationId == 4).ToList().Count();
            ViewBag.AssaultLocation5 = db.AssaultRecords.Where(l => l.AssaultLocationId == 5).ToList().Count();
            ViewBag.AssaultLocation6 = db.AssaultRecords.Where(l => l.AssaultLocationId == 6).ToList().Count();
            ViewBag.AssaultLocation7 = db.AssaultRecords.Where(l => l.AssaultLocationId == 7).ToList().Count();

            ViewBag.AlcoholAndOrDrug = db.AssaultRecords.Where(a => a.AlcoholAndOrDrugId == 1).ToList().Count();
            ViewBag.AlcoholAndOrDrug2 = db.AssaultRecords.Where(a => a.AlcoholAndOrDrugId == 2).ToList().Count();
            ViewBag.AlcoholAndOrDrug3 = db.AssaultRecords.Where(a => a.AlcoholAndOrDrugId == 3).ToList().Count();

            ViewBag.AssaultType = db.AssaultRecords.Where(a => a.AssaultTypeId == 1).ToList().Count();
            ViewBag.AssaultType2 = db.AssaultRecords.Where(a => a.AssaultTypeId == 2).ToList().Count();
            ViewBag.AssaultType3 = db.AssaultRecords.Where(a => a.AssaultTypeId == 3).ToList().Count();
            ViewBag.AssaultType4 = db.AssaultRecords.Where(a => a.AssaultTypeId == 4).ToList().Count();

            ViewBag.Relationship = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 1).ToList().Count();
            ViewBag.Relationship2 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 2).ToList().Count();
            ViewBag.Relationship3 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 3).ToList().Count();
            ViewBag.Relationship4 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 4).ToList().Count();
            ViewBag.Relationship5 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 5).ToList().Count();
            ViewBag.Relationship6 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 6).ToList().Count();
            ViewBag.Relationship7 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 7).ToList().Count();
            ViewBag.Relationship8 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 8).ToList().Count();
            ViewBag.Relationship9 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 9).ToList().Count();
            ViewBag.Relationship10 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 10).ToList().Count();
            ViewBag.Relationship11 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 11).ToList().Count();
            ViewBag.Relationship12 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 12).ToList().Count();
            ViewBag.Relationship13 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 13).ToList().Count();
            ViewBag.Relationship14 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 14).ToList().Count();
            ViewBag.Relationship15 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 15).ToList().Count();
            ViewBag.Relationship16 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 16).ToList().Count();
            ViewBag.Relationship17 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 17).ToList().Count();
            ViewBag.Relationship18 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 18).ToList().Count();
            ViewBag.Relationship19 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 19).ToList().Count();
            ViewBag.Relationship20 = db.AssaultRecords.Where(a => a.AttackerRelationshipId == 20).ToList().Count();

            return View();

        }
    }
}
