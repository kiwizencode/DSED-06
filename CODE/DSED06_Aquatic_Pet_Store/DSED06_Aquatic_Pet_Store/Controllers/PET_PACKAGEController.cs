using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DSED06_Aquatic_Pet_Store.Models;

namespace DSED06_Aquatic_Pet_Store.Controllers
{
    public class PET_PACKAGEController : Controller
    {
        private AQUATIC_PET_STORE_Entities db = new AQUATIC_PET_STORE_Entities();

        // GET: PET_PACKAGE
        public ActionResult Index()
        {
            return View(db.PET_PACKAGE.ToList());
        }

        // GET: PET_PACKAGE/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PET_PACKAGE pET_PACKAGE = db.PET_PACKAGE.Find(id);
            if (pET_PACKAGE == null)
            {
                return HttpNotFound();
            }
            return View(pET_PACKAGE);
        }

        // GET: PET_PACKAGE/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PET_PACKAGE/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PK,DESCRIPTION")] PET_PACKAGE pET_PACKAGE)
        {
            if (ModelState.IsValid)
            {
                db.PET_PACKAGE.Add(pET_PACKAGE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pET_PACKAGE);
        }

        // GET: PET_PACKAGE/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PET_PACKAGE pET_PACKAGE = db.PET_PACKAGE.Find(id);
            if (pET_PACKAGE == null)
            {
                return HttpNotFound();
            }
            return View(pET_PACKAGE);
        }

        // POST: PET_PACKAGE/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PK,DESCRIPTION")] PET_PACKAGE pET_PACKAGE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pET_PACKAGE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pET_PACKAGE);
        }

        // GET: PET_PACKAGE/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PET_PACKAGE pET_PACKAGE = db.PET_PACKAGE.Find(id);
            if (pET_PACKAGE == null)
            {
                return HttpNotFound();
            }
            return View(pET_PACKAGE);
        }

        // POST: PET_PACKAGE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PET_PACKAGE pET_PACKAGE = db.PET_PACKAGE.Find(id);
            db.PET_PACKAGE.Remove(pET_PACKAGE);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
