using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using baptismOfFire.Models;

namespace baptismOfFire.Controllers
{
    public class DeploymentsController : Controller
    {
        private baptismOfFireContext db = new baptismOfFireContext();

        // GET: Deployments
        public ActionResult Index()
        {
            return View(db.Deployments.ToList());
        }

        // GET: Deployments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Deployment deployment = db.Deployments.Find(id);
            if (deployment == null)
            {
                return HttpNotFound();
            }
            return View(deployment);
        }

        // GET: Deployments/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Deployments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CreateDate")] Deployment deployment)
        {
            if (ModelState.IsValid)
            {
                db.Deployments.Add(deployment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(deployment);
        }

        // GET: Deployments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Deployment deployment = db.Deployments.Find(id);
            if (deployment == null)
            {
                return HttpNotFound();
            }

            ViewBag.AllCertificates=db.Certificates.ToList();

            return View(deployment);
        }

        // POST: Deployments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CreateDate,SelectedCertificateId")] Deployment deployment)
        {
            if (ModelState.IsValid)
            {

                // This "SelectedCertificateID" stuff is doing nothing helpful!
                int SelectedCertificateId = int.Parse(Request.Form["SelectedCertificateId"]);
                deployment.Certificate = db.Certificates.Find(SelectedCertificateId);

                db.Entry(deployment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(deployment);
        }

        // GET: Deployments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Deployment deployment = db.Deployments.Find(id);
            if (deployment == null)
            {
                return HttpNotFound();
            }
            return View(deployment);
        }

        // POST: Deployments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Deployment deployment = db.Deployments.Find(id);
            db.Deployments.Remove(deployment);
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
