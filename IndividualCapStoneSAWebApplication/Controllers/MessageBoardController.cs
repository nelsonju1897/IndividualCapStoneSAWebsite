using IndividualCapStoneSAWebApplication.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IndividualCapStoneSAWebApplication.Controllers
{
    public class MessageBoardController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: MessageBoard
        public ActionResult Index()
        {
            return View(db.MessageBoard.ToList());
        }

        // GET: MessageBoard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MessageBoard/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: MessageBoard/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "MessageBoardId,MessageBoardName,MessageBoardEntry,SurvivorId")]MessageBoard messageBoard)
        {
            try
            {
                // TODO: Add insert logic here
                var userId = User.Identity.GetUserId();
                Survivor survivor = db.Survivor.FirstOrDefault(s => s.ApplicationId == userId);
                messageBoard.SurvivorId = survivor.SurvivorId;
                db.MessageBoard.Add(messageBoard);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MessageBoard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MessageBoard/Edit/5
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

        // GET: MessageBoard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MessageBoard/Delete/5
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
