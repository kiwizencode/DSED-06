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
    public class PET_PACKINGController : Controller
    {
        private AQUATIC_PET_STORE_Entities db = new AQUATIC_PET_STORE_Entities();

        // GET: PET_PACKING
        public ActionResult Index()
        {
            return View(db.PET_PACKING.ToList());
        }

        // GET: PET_PACKING/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PET_PACKING pET_PACKING = db.PET_PACKING.Find(id);
            if (pET_PACKING == null)
            {
                return HttpNotFound();
            }
            return View(pET_PACKING);
        }

        // GET: PET_PACKING/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PET_PACKING/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PK,DESCRIPTION")] PET_PACKING pET_PACKING)
        {
            if (ModelState.IsValid)
            {
                db.PET_PACKING.Add(pET_PACKING);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pET_PACKING);
        }

        // GET: PET_PACKING/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PET_PACKING pET_PACKING = db.PET_PACKING.Find(id);
            if (pET_PACKING == null)
            {
                return HttpNotFound();
            }
            return View(pET_PACKING);
        }

        // POST: PET_PACKING/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PK,DESCRIPTION")] PET_PACKING pET_PACKING)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pET_PACKING).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pET_PACKING);
        }

        // GET: PET_PACKING/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PET_PACKING pET_PACKING = db.PET_PACKING.Find(id);
            if (pET_PACKING == null)
            {
                return HttpNotFound();
            }
            return View(pET_PACKING);
        }

        // POST: PET_PACKING/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PET_PACKING pET_PACKING = db.PET_PACKING.Find(id);
            db.PET_PACKING.Remove(pET_PACKING);
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
