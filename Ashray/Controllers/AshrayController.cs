using Ashray.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ashray.Filter;
using PagedList;
namespace Ashray.Controllers
{
    [CustomAuthenticationFilter]
    public class AshrayController : Controller
    {
        // GET: Ashray
        public ActionResult Index()
        {
            var homeDashboard = Registation.GetHomeDashboard();
            return View(homeDashboard);
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

        public ActionResult PostHospital(int? page)
        {
            var list = Registation.GetPosthospitalInfo();
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(list.ToPagedList(pageNumber, pageSize));
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

        public ActionResult ViewPatient(int id, string name, string rtpctr)
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
                patientHistory.PatientInfo.EmergencyContactName1 = history.EmergencyContactName1;
                patientHistory.PatientInfo.EmergencyContactNumber1 = history.EmergencyContactNumber1;
                using(var db = new AshrayEntities())
				{
                    var matchedInfo = db.PatientInfoes.FirstOrDefault(x => x.PatientId == id);
                    if(matchedInfo!=null)
					{
                        patientHistory.PatientInfo.EmergencyContactName1 = matchedInfo.EmergencyContactName1;
                        patientHistory.PatientInfo.EmergencyContactNumber1 = matchedInfo.EmergencyContactNumber1;
                    }
				}
            }
            patientHistory.Files = new List<FileUpload>();
            string foldername = patientHistory.PatientInfo.PatientId + "_" + patientHistory.PatientInfo.PatientName;
            string pathname = Server.MapPath("~/UploadedFiles/") + foldername; // Give the specific path
            if (Directory.Exists(pathname))
            {
                var fileInfo = Directory.GetFiles(pathname);
                if (fileInfo.Length > 0)
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

        public ActionResult Delete(int id)
		{
            Registation.DeletePatientInfo(id);
            return RedirectToAction("PostHospital");
		}

        [HttpPost]
        public ActionResult ViewPatient(PatientHistory ph, IEnumerable<HttpPostedFileBase> files)
        {

            string foldername = ph.PatientInfo.PatientId + "_" + ph.PatientInfo.PatientName;
            string pathname = Server.MapPath("~/UploadedFiles/") + foldername;  // Give the specific path  
            if (!(Directory.Exists(pathname)))
            {
                Directory.CreateDirectory(pathname);
            }
            if (files != null)
            {
                foreach (var file in files)
                {
                    if (file != null && file.ContentLength > 0)
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