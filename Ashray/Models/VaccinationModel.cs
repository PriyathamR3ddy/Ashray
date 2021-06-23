using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ashray.Models
{
    public class VaccinationModel
    {
        public VaccinationModel()
		{
            EmpVaccineDetails = new List<EmpVaccineDetails>();
		}
        
        public string EmpCode { get; set; }
        public string Location { get; set; }
        public bool Vaccinated { get; set; }
         
                
        public DateTime TentitiveDate { get; set; }

        public bool FeedingMother { get; set; }

        public bool CovidCheck { get; set; }

        public bool VaccineInfection { get; set; }

        public bool WillingToVaccine { get; set; }

        public List<EmpVaccineDetails> EmpVaccineDetails { get; set; }
    }

    public class EmpVaccineDetails
	{
		public string PersonName { get; set; }
		public DateTime DateOfVaccination { get; set; }
		public string DoseTaken { get; set; }
		public string VaccineName { get; set; }
		public string Relation { get; set; }
		public DateTime DueDate { get; set; }
	}
}