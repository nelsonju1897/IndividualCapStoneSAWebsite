using IndividualCapStoneSAWebApplication.Models;
using System;
using System.Collections.Generic;
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
            return View();
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
        public ActionResult Create(FormCollection collection)
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

        // GET: PrivateJournal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrivateJournal/Edit/5
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

        // GET: PrivateJournal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrivateJournal/Delete/5
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
