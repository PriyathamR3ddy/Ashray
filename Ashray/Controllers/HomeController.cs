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
                ViewBag.states = db.StateDetails.ToList().Select(state => new SelectListItem
                {
                    Text = state.StateName,
                    Value = state.StateId.ToString()
                });
                ViewBag.location = db.LocationDetails.ToList().Select(loc => new SelectListItem
                {
                    Text = loc.LocationName,
                    Value = loc.LocationId.ToString()
                });
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

        public ActionResult ViewPatient()
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
            var res = Registation.InsertRegistration(registation);
            return View();
        }

        [HttpPost]
        public ActionResult PatientRegistration(PatientInfo patientInfo)
        {
            var res = Registation.InsertPatientInfo(patientInfo);
            return View();
        }
    }
}