using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ashray.Models
{
	public class HomeDashboard
	{
		public int TotalBeds { get; set; }

		public int AvailableBeds { get; set; }

		public int Recovered { get; set; }

		public int DischargedCount { get; set; }

		public int AdmittedCount { get; set; }

		public int TotalAdmissions { get; set; }
		public int TotalDischarged { get; set; }

		public int FemaleCount { get; set; }

		public int MaleCount { get; set; }

		public List<PatientDashboard> PatientDashboard { get; set; }
	}
}