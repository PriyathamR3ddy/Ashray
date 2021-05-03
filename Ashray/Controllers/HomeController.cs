using System;
using System.Collections.Generic;
using System.IO;
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
            var homeDashboard = Registation.GetHomeDashboard();
            return View(homeDashboard);
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
            var dashboard = Registation.GetDashboard();            
            return View(dashboard);
        }

        public ActionResult FindBed()
        {
            return View();
        }

        public ActionResult PostHospital()
        {
            var list = Registation.GetPosthospitalInfo();
            return View(list);
        }

        public ActionResult PostBed()
        {
            return View();
        }

        public ActionResult BedTypes()
        {
            var bedInfo = Registation.GetBedTypeInfo();
            return View(bedInfo);
        }

        public ActionResult PatientRegistration()
        {
            return View();
        }

        public ActionResult ViewPatient(int id,string name,string rtpctr)
        {
            PatientHistory patientHistory = new PatientHistory();            
            patientHistory.PatientInfo = new PatientInfo();
            patientHistory.PatientInfo.PatientId = id;
            patientHistory.PatientInfo.PatientName = name;
            patientHistory.PatientInfo.RTPCRTestNumber = rtpctr;
            var history = Registation.GetPatientHistory(id);
			if (history != null)
			{
				patientHistory.SPO2 = history.SPO2;
				patientHistory.BP = history.BP;
				patientHistory.Temperature = history.Temperature;
				patientHistory.BedNumber = history.BedNumber;
				patientHistory.RoomNumber = history.RoomNumber;
				patientHistory.CheckinDateTime = history.CheckinDateTime;
				patientHistory.CheckoutDatetime = history.CheckoutDatetime;
				patientHistory.DischargeInfo = history.DischargeInfo;
			}
            patientHistory.Files = new List<FileUpload>();
            string foldername = patientHistory.PatientInfo.PatientId + "_" + patientHistory.PatientInfo.PatientName;
            string pathname = Server.MapPath("~/UploadedFiles/") + foldername; // Give the specific path
            if(Directory.Exists(pathname))
			{
                var fileInfo = Directory.GetFiles(pathname);
                if(fileInfo.Length >0)
				{
					foreach (var item in fileInfo)
					{
                        var file = new FileUpload();
                        file.FileId = patientHistory.PatientInfo.PatientId.ToString();
                        file.FileName = Path.GetFileName(item);
                        file.FileUrl = patientHistory.PatientInfo.PatientId + "_" + patientHistory.PatientInfo.PatientName + System.IO.Path.DirectorySeparatorChar + Path.GetFileName(item);
                        patientHistory.Files.Add(file);
                    }
				}

            }           
            return View(patientHistory);
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
            return RedirectToAction("FindHospital");
        }

        [HttpPost]
        public ActionResult ViewPatient(PatientHistory ph, IEnumerable<HttpPostedFileBase> files)
        {

            string foldername = ph.PatientInfo.PatientId +"_"+ ph.PatientInfo.PatientName;
            string pathname = Server.MapPath("~/UploadedFiles/") + foldername;  // Give the specific path  
            if (!(Directory.Exists(pathname)))
            {
                Directory.CreateDirectory(pathname);
            }
            if (files != null)
            {
                foreach (var file in files)
                {
                    if (file.ContentLength > 0)
                    {
                        var fileName = Path.GetFileName(file.FileName);
                        var path = Path.Combine(pathname, fileName);
                        file.SaveAs(path);
                    }
                }
            }
            var res = Registation.InsertPatientHistory(ph);
            return RedirectToAction("PostHospital");
        }

        public FileResult Download(string id)
		{
           byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/UploadedFiles/") + id);          
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, id);
        }
    }
}