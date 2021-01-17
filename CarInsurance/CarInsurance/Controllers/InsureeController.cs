using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                {
                    int bQuote = 50;
                    DateTime today = DateTime.Now;
                    //DateTime uDate = today.Date;
                    insuree.DateOfBirth = insuree.DateOfBirth.Date;
                    DateTime age = today.AddYears(-insuree.DateOfBirth.Year);
                    // quote per age
                    if (age.Year <= 18)
                    {
                        insuree.Quote = bQuote + 100;
                    }
                    else if (age.Year >= 19 && age.Year <= 25)
                    {
                        insuree.Quote = bQuote + 50;
                    }
                    else if (age.Year > 25)
                    {
                        insuree.Quote = bQuote + 25;
                    }
                    // car year quote
                    if (insuree.Quote <= 2000)
                    {
                        insuree.Quote = bQuote + 25;
                    }
                    else if (insuree.Quote >= 2015)
                    {
                        insuree.Quote = bQuote + 25;
                    }
                    // car make/model quote
                    if (insuree.CarModel == "Porsche")
                    {
                        insuree.Quote = bQuote + 25;
                    }
                    else if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera")
                    {
                        insuree.Quote = bQuote + 25;
                    }
                    // iteration per speeding ticket
                    for (int i = 0; i < insuree.SpeedingTickets; i++)
                    {
                        insuree.Quote = bQuote + 10;
                    }
                    // 25% time baby
                    if (insuree.DUI == true)
                    {
                        double duiCost = bQuote * .25;
                        int numDCost = Convert.ToInt32(duiCost);
                        insuree.Quote = bQuote + numDCost;
                    }
                    // love their full coverage 50% time
                    if (insuree.CoverageType == true)
                    {
                        double fullCov = bQuote * .50;
                        int numFullCov = Convert.ToInt32(fullCov);
                        insuree.Quote = bQuote + numFullCov;
                    }

                    
                    }
                    db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
