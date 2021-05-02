using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ashray.Models
{
	public class Dashboard
	{
		public int CentreId { get; set; }

		public string CentreName { get; set; }

		public int BedCount { get; set; }

		public int OccupiedBeds { get; set; }

		public int AvailableBeds { get; set; }
	}
}