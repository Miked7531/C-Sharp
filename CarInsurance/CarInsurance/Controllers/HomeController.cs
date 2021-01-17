using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insuree(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, int carYear, string carMake, string carModel, bool dUI, int speedingTickets, bool coverageType, decimal quote)
        {
            int bQuote = 50;
            var today = DateTime.Today;
            var age = today.Year - dateOfBirth.Year;
            // quote per age
            if (age <= 18)
            {
                quote = bQuote + 100;
            }
            else if (age >= 19 && age <= 25)
            {
                quote = bQuote + 50;
            }
            else if (age > 25)
            {
                quote = bQuote + 25;
            }
            // car year quote
            if (carYear <= 2000)
            {
                quote = bQuote + 25;
            }
            else if (carYear >= 2015)
            {
                quote = bQuote + 25;
            }
            // car make/model quote
            if (carMake == "Porsche")
            {
                quote = bQuote + 25;
            }
            else if (carMake == "Porsche" && carModel == "911 Carrera")
            {
                quote = bQuote + 25;
            }
            // iteration per speeding ticket
            for (int i = 0; i < speedingTickets; i++)
            {
                quote = bQuote + 10;
            }
            // 25% time baby
            if (dUI == true)
            {
                double duiCost = bQuote * .25;
                int numDCost = Convert.ToInt32(duiCost);
                quote = bQuote + numDCost;
            }
            // love their full coverage 50% time
            if (coverageType == true)
            {
                double fullCov = bQuote * .50;
                int numFullCov = Convert.ToInt32(fullCov);
                quote = bQuote + numFullCov;
            }

            using (InsuranceEntities db = new InsuranceEntities())
            {
                var quoteInfo = new Insuree();
                quoteInfo.FirstName = firstName;
                quoteInfo.LastName = lastName;
                quoteInfo.EmailAddress = emailAddress;
                quoteInfo.DateOfBirth = dateOfBirth;
                quoteInfo.CarYear = carYear;
                quoteInfo.CarMake = carMake;
                quoteInfo.CarModel = carModel;
                quoteInfo.DUI = dUI;
                quoteInfo.SpeedingTickets = speedingTickets;
                quoteInfo.CoverageType = coverageType;
                quoteInfo.Quote = quote;

                db.Insurees.Add(quoteInfo);
                db.SaveChanges();

                return View("qResult", quoteInfo);
            }


            
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Hey there!";

            return View();
        }
    }
}