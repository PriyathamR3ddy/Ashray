using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ashray.Models;

namespace Ashray.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registration()
        {
            using (var db = new AshrayEntities())
            {
                ViewBag.states = db.StateDetails.ToList();
                ViewBag.location = db.LocationDetails.ToList();
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult FindHospital()
        {
            return View();
        }

        public ActionResult FindBed()
        {
            return View();
        }

        public ActionResult PostHospital()
        {
            return View();
        }

        public ActionResult PostBed()
        {
            return View();
        }

        public ActionResult BedTypes()
        {
            return View();
        }

        public ActionResult PatientRegistration()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Registration(Registation registation)
        {
            return View();
        }
    }
}