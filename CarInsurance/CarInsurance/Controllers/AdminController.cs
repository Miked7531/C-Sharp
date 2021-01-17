using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var quoteAdmin = db.Insurees;
                var adminQuotes = new List<Insuree>();
                foreach (var quote in quoteAdmin)
                {
                    var insureeInfo = new Insuree();
                    insureeInfo.Id = quote.Id;
                    insureeInfo.FirstName = quote.FirstName;
                    insureeInfo.LastName = quote.LastName;
                    insureeInfo.EmailAddress = quote.EmailAddress;
                    insureeInfo.Quote = quote.Quote;
                    adminQuotes.Add(insureeInfo);
                }
                return View(adminQuotes);
            }
            
        }
    }
}