using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BTL_SQL.Models;

namespace BTL_SQL.Controllers
{
    public class NotDaysController : Controller
    {
        private DemoDbContext db = new DemoDbContext();

        // GET: NotDays
        public ActionResult Index()
        {
            return View(db.NotDays.ToList());
        }

        // GET: NotDays/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotDay notDay = db.NotDays.Find(id);
            if (notDay == null)
            {
                return HttpNotFound();
            }
            return View(notDay);
        }

        // GET: NotDays/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NotDays/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NhatKySo,NoiDung")] NotDay notDay)
        {
            if (ModelState.IsValid)
            {
                db.NotDays.Add(notDay);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(notDay);
        }

        // GET: NotDays/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotDay notDay = db.NotDays.Find(id);
            if (notDay == null)
            {
                return HttpNotFound();
            }
            return View(notDay);
        }

        // POST: NotDays/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NhatKySo,NoiDung")] NotDay notDay)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notDay).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(notDay);
        }

        // GET: NotDays/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NotDay notDay = db.NotDays.Find(id);
            if (notDay == null)
            {
                return HttpNotFound();
            }
            return View(notDay);
        }

        // POST: NotDays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NotDay notDay = db.NotDays.Find(id);
            db.NotDays.Remove(notDay);
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
