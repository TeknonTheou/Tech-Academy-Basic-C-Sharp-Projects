using CarInsurance.Models;
using CarInsurance.ViewModels;
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
            using (var db = new InsuranceEntities())
            {
                var quotes = db.Insurees;
                var quoteVms = new List<QuoteVm>();
                foreach (var quote in quotes)
                {
                    var quoteVm = new QuoteVm();
                    quoteVm.FirstName = quote.FirstName;
                    quoteVm.LastName = quote.LastName;
                    quoteVm.EmailAddress = quote.Email_Address;
                    quoteVm.QuoteAmount = (decimal)quote.Quote;

                    quoteVms.Add(quoteVm);
                }
                return View(quoteVms);
            }
        }
    }
}