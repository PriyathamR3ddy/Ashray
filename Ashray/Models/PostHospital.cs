using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ashray.Models
{
	public class PostHospital
	{
		public string CenterName { get; set; }
		public string PatientName { get; set; }
		public string RegistrationDate { get; set; }

		public string Gender { get; set; }

		public string Status { get; set; }

		public int PatientId { get; set; }

		public string RTPCRNumber { get; set; }
	}
}