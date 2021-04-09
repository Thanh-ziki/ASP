using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PTPMQL._1.Models;

namespace PTPMQL._1.Controllers
{
    public class QuanLyThuViensController : Controller
    {
        private DemoDbContext db = new DemoDbContext();

        // GET: QuanLyThuViens
        public ActionResult Index()
        {
            return View(db.QuanLyThuViens.ToList());
        }

        // GET: QuanLyThuViens/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanLyThuVien quanLyThuVien = db.QuanLyThuViens.Find(id);
            if (quanLyThuVien == null)
            {
                return HttpNotFound();
            }
            return View(quanLyThuVien);
        }

        // GET: QuanLyThuViens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuanLyThuViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaSach,TenSach,MaLoaiSach,SoLuong")] QuanLyThuVien quanLyThuVien)
        {
            if (ModelState.IsValid)
            {
                db.QuanLyThuViens.Add(quanLyThuVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quanLyThuVien);
        }

        // GET: QuanLyThuViens/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanLyThuVien quanLyThuVien = db.QuanLyThuViens.Find(id);
            if (quanLyThuVien == null)
            {
                return HttpNotFound(); 
            }
            return View(quanLyThuVien);
        }

        // POST: QuanLyThuViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaSach,TenSach,MaLoaiSach,SoLuong")] QuanLyThuVien quanLyThuVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quanLyThuVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quanLyThuVien);
        }

        // GET: QuanLyThuViens/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanLyThuVien quanLyThuVien = db.QuanLyThuViens.Find(id);
            if (quanLyThuVien == null)
            {
                return HttpNotFound();
            }
            return View(quanLyThuVien);
        }

        // POST: QuanLyThuViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            QuanLyThuVien quanLyThuVien = db.QuanLyThuViens.Find(id);
            db.QuanLyThuViens.Remove(quanLyThuVien);
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
