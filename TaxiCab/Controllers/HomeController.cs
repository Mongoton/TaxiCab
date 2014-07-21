using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaxiCab.Models;
using System.Net;


namespace TaxiCab.Controllers
{
    public class HomeController : Controller
    {
        //private readonly TaxiModel _taxiModel = new TaxiModel();

        public ActionResult Index()
        {
            ViewBag.Message = "Please enter your taxi cab data:";

            return View();
        }

        [HttpPost]
        public ActionResult Index(TaxiModel rideinfo)
        {
            rideinfo.TaxiID = "1";
            rideinfo.TaxiMinutesOver6 = 1;
            rideinfo.TaxiMinutesUnder6 = 2;
            rideinfo.TaxiRideDate = new DateTime(2014, 5, 1, 12, 32, 30);

            //return new HttpStatusCodeResult(HttpStatusCode.OK);
            //return View(rideinfo);
            return Json(rideinfo, JsonRequestBehavior.AllowGet);
        }
    }
}
