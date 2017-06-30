using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DSED06_WebApp.Models;

namespace DSED06_WebApp.Controllers
{
    public class AQUATIC_PETController : Controller
    {
        private DESD06_AQUASHOPEntities db = new DESD06_AQUASHOPEntities();

        // GET: AQUATIC_PET
        public ActionResult Index()
        {
            var aQUATIC_PET = db.AQUATIC_PET.Include(a => a.AQUATIC_GROUP);
            return View(aQUATIC_PET.ToList());
        }

        // GET: AQUATIC_PET/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AQUATIC_PET aQUATIC_PET = db.AQUATIC_PET.Find(id);
            if (aQUATIC_PET == null)
            {
                return HttpNotFound();
            }
            return View(aQUATIC_PET);
        }

        // GET: AQUATIC_PET/Create
        public ActionResult Create()
        {
            ViewBag.GROUP_FK = new SelectList(db.AQUATIC_GROUP, "ID_PK", "NAME");
            return View();
        }

        // POST: AQUATIC_PET/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PK,COMMON,SCIENTIFIC,GROUP_FK")] AQUATIC_PET aQUATIC_PET)
        {
            if (ModelState.IsValid)
            {
                db.AQUATIC_PET.Add(aQUATIC_PET);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GROUP_FK = new SelectList(db.AQUATIC_GROUP, "ID_PK", "NAME", aQUATIC_PET.GROUP_FK);
            return View(aQUATIC_PET);
        }

        // GET: AQUATIC_PET/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AQUATIC_PET aQUATIC_PET = db.AQUATIC_PET.Find(id);
            if (aQUATIC_PET == null)
            {
                return HttpNotFound();
            }
            ViewBag.GROUP_FK = new SelectList(db.AQUATIC_GROUP, "ID_PK", "NAME", aQUATIC_PET.GROUP_FK);
            return View(aQUATIC_PET);
        }

        // POST: AQUATIC_PET/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PK,COMMON,SCIENTIFIC,GROUP_FK")] AQUATIC_PET aQUATIC_PET)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aQUATIC_PET).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GROUP_FK = new SelectList(db.AQUATIC_GROUP, "ID_PK", "NAME", aQUATIC_PET.GROUP_FK);
            return View(aQUATIC_PET);
        }

        // GET: AQUATIC_PET/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AQUATIC_PET aQUATIC_PET = db.AQUATIC_PET.Find(id);
            if (aQUATIC_PET == null)
            {
                return HttpNotFound();
            }
            return View(aQUATIC_PET);
        }

        // POST: AQUATIC_PET/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AQUATIC_PET aQUATIC_PET = db.AQUATIC_PET.Find(id);
            db.AQUATIC_PET.Remove(aQUATIC_PET);
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
