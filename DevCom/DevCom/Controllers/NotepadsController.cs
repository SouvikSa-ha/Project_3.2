using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DevCom.Models;

namespace DevCom.Controllers
{
    public class NotepadsController : Controller
    {
        private DevComDBEntities db = new DevComDBEntities();

        // GET: Notepads
        public ActionResult Index()
        {
            var notepads = db.Notepads.Include(n => n.Tag).Include(n => n.User);
            return View(notepads.ToList());
        }

        // GET: Notepads/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notepad notepad = db.Notepads.Find(id);
            if (notepad == null)
            {
                return HttpNotFound();
            }
            return View(notepad);
        }

        // GET: Notepads/Create
        public ActionResult Create()
        {
            ViewBag.Tag_Id = new SelectList(db.Tags, "Tag_Id", "Tag1");
            ViewBag.Uid = new SelectList(db.Users, "Uid", "Username");
            return View();
        }

        // POST: Notepads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Notepad_Id,Uid,Tag_Id,Title,Icon,Creation_Date,Update_Date")] Notepad notepad)
        {
            if (ModelState.IsValid)
            {
                db.Notepads.Add(notepad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Tag_Id = new SelectList(db.Tags, "Tag_Id", "Tag1", notepad.Tag_Id);
            ViewBag.Uid = new SelectList(db.Users, "Uid", "Username", notepad.Uid);
            return View(notepad);
        }

        // GET: Notepads/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notepad notepad = db.Notepads.Find(id);
            if (notepad == null)
            {
                return HttpNotFound();
            }
            ViewBag.Tag_Id = new SelectList(db.Tags, "Tag_Id", "Tag1", notepad.Tag_Id);
            ViewBag.Uid = new SelectList(db.Users, "Uid", "Username", notepad.Uid);
            return View(notepad);
        }

        // POST: Notepads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Notepad_Id,Uid,Tag_Id,Title,Icon,Creation_Date,Update_Date")] Notepad notepad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(notepad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Tag_Id = new SelectList(db.Tags, "Tag_Id", "Tag1", notepad.Tag_Id);
            ViewBag.Uid = new SelectList(db.Users, "Uid", "Username", notepad.Uid);
            return View(notepad);
        }

        // GET: Notepads/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Notepad notepad = db.Notepads.Find(id);
            if (notepad == null)
            {
                return HttpNotFound();
            }
            return View(notepad);
        }

        // POST: Notepads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Notepad notepad = db.Notepads.Find(id);
            db.Notepads.Remove(notepad);
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
