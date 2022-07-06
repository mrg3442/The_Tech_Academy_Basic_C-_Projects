using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            table.Quote = 50;
            int age = 0;
            age = DateTime.Now.Subtract(table.DateOfBirth).Days;
            age = age / 365;
            if (ModelState.IsValid)
            {
                if (age < 18)
                {
                    table.Quote += 100;
                }
                else if (age > 18 && age < 26)
                {
                    table.Quote += 50;
                }
                else
                {
                    table.Quote += 25;
                }
                if (table.CarYear < 2000)
                {
                    table.Quote += 25;
                }
                else if (table.CarYear > 2015)
                {
                    table.Quote += 25;
                }
                if (table.CarMake == "Porsche")
                {
                    table.Quote += 25;
                }
                if (table.CarMake == "Porsche" && table.CarModel == "911 Carrera")
                {
                    table.Quote += 25;
                }
                for (int i = table.SpeedingTickets ; i > 0; i--)
                {
                    table.Quote += 10;
                }
                if (table.DUI)
                {
                    table.Quote = table.Quote * 1.25m;
                }
                if (table.CoverageType)
                {
                    table.Quote = table.Quote * 1.5m;
                }
                db.Tables.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            table.Quote = 50;
            int age = 0;
            age = DateTime.Now.Subtract(table.DateOfBirth).Days;
            age = age / 365;
            if (ModelState.IsValid)
            {
                if (age < 18)
                {
                    table.Quote += 100;
                }
                else if (age > 18 && age < 26)
                {
                    table.Quote += 50;
                }
                else
                {
                    table.Quote += 25;
                }
                if (table.CarYear < 2000)
                {
                    table.Quote += 25;
                }
                else if (table.CarYear > 2015)
                {
                    table.Quote += 25;
                }
                if (table.CarMake == "Porsche")
                {
                    table.Quote += 25;
                }
                if (table.CarMake == "Porsche" && table.CarModel == "911 Carrera")
                {
                    table.Quote += 25;
                }
                for (int i = table.SpeedingTickets; i > 0; i--)
                {
                    table.Quote += 10;
                }
                if (table.DUI)
                {
                    table.Quote = table.Quote * 1.25m;
                }
                if (table.CoverageType)
                {
                    table.Quote = table.Quote * 1.5m;
                }
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
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

        public ActionResult Admin()
        {
            var db = new InsuranceEntities();
            var coverages = db.Tables;
            var coveragesVM = new List<CoverageVM>();
            foreach(var coverage in coverages)
            {
                var coverageVM = new CoverageVM();
                coverageVM.FirstName = coverage.FirstName;
                coverageVM.LastName = coverage.LastName;
                coverageVM.EmailAddress = coverage.EmailAddress;
                coverageVM.Quote = (int)coverage.Quote;
                coveragesVM.Add(coverageVM);
            }
            return View(coveragesVM);
        }
    }
}
