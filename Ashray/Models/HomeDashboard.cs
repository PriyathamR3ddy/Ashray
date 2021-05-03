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
	}
}