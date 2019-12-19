﻿using IndividualCapStoneSAWebApplication.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return View();
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
            return View();
        }

        // POST: Survivor/Edit/5
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

        // GET: Survivor/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Survivor/Delete/5
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