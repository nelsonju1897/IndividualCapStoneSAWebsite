using IndividualCapStoneSAWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndividualCapStoneSAWebApplication.Controllers
{
    public class AssaultTypeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: AssaultType
        public ActionResult GetAssaultTypes()
        {
            var assaultTypes = db.AssaultType.ToList();
            return View(assaultTypes);
        }
        public ActionResult Index()
        {
            return View();
        }

        // GET: AssaultType/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AssaultType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AssaultType/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "SurvivorId,FirstName,LastName,EmergencyContactNumber,EmailAddress,ApplicationId")]Survivor survivor)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AssaultType/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AssaultType/Edit/5
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

        // GET: AssaultType/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AssaultType/Delete/5
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
