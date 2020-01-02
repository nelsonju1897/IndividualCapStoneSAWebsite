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
            return View();
        }

        // GET: AssaultRecord/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AssaultRecord/Create
        public ActionResult Create()
        {
            ViewBag.Relationships = new SelectList(db.AttackerRelationship.ToList(), "AttackerRelationshipName", "AttackerRelationshipName");
            ViewBag.AssaultTypes = new SelectList(db.AssaultType.ToList(), "AssaultTypeName", "AssaultTypeName");
            ViewBag.AlcoholAndOrDrugs = new SelectList(db.AlcoholAndOrDrugs.ToList(), "AlcoholAndOrDrugsName", "AlcoholAndOrDrugsName");
            ViewBag.AssaultLocation = new SelectList(db.AssaultLocation.ToList(), "AssaultLocationName", "AssaultLocationName");
            return View();
        }

        // POST: AssaultRecord/Create
        [HttpPost]
        public ActionResult Create(AssaultRecord assaultRecord)
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
                ViewBag.Relationships = new SelectList(db.AttackerRelationship.ToList(), "AttackerRelationshipName", "AttackerRelationshipName");
                ViewBag.AssaultTypes = new SelectList(db.AssaultType.ToList(), "AssaultTypeName", "AssaultTypeName");
                ViewBag.AlcoholAndOrDrugs = new SelectList(db.AlcoholAndOrDrugs.ToList(), "AlcoholAndOrDrugsName", "AlcoholAndOrDrugsName");
                ViewBag.AssaultLocation = new SelectList(db.AssaultLocation.ToList(), "AssaultLocationName", "AssaultLocationName");
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
    }
}
