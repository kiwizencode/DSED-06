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
    public class AQUATIC_GROUPController : Controller
    {
        private DESD06_AQUASHOPEntities db = new DESD06_AQUASHOPEntities();

        private string Title = "Pet Group";

        // GET: AQUATIC_GROUP
        public ActionResult Index()
        {
            return View(db.AQUATIC_GROUP.ToList());
        }

        // GET: AQUATIC_GROUP/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AQUATIC_GROUP aQUATIC_GROUP = db.AQUATIC_GROUP.Find(id);
            if (aQUATIC_GROUP == null)
            {
                return HttpNotFound();
            }
            return View(aQUATIC_GROUP);
        }

        // GET: AQUATIC_GROUP/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AQUATIC_GROUP/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PK,NAME")] AQUATIC_GROUP aQUATIC_GROUP)
        {
            if (ModelState.IsValid)
            {
                db.AQUATIC_GROUP.Add(aQUATIC_GROUP);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aQUATIC_GROUP);
        }

        // GET: AQUATIC_GROUP/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AQUATIC_GROUP aQUATIC_GROUP = db.AQUATIC_GROUP.Find(id);
            if (aQUATIC_GROUP == null)
            {
                return HttpNotFound();
            }
            return View(aQUATIC_GROUP);
        }

        // POST: AQUATIC_GROUP/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PK,NAME")] AQUATIC_GROUP aQUATIC_GROUP)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aQUATIC_GROUP).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aQUATIC_GROUP);
        }

        // GET: AQUATIC_GROUP/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AQUATIC_GROUP aQUATIC_GROUP = db.AQUATIC_GROUP.Find(id);
            if (aQUATIC_GROUP == null)
            {
                return HttpNotFound();
            }
            return View(aQUATIC_GROUP);
        }

        // POST: AQUATIC_GROUP/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AQUATIC_GROUP aQUATIC_GROUP = db.AQUATIC_GROUP.Find(id);
            db.AQUATIC_GROUP.Remove(aQUATIC_GROUP);
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
