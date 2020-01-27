using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Country.Controllers
{
    public class CountryController : Controller
    {
        // GET: Country
        public ActionResult Index()
        {
            ViewBag.Countries = new List<string>()
            {
                "India",
                "Sweden",
                "China",
                "USA"
            };
            return View();
        }
    }
}