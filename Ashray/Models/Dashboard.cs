using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ashray.Models
{
	public class Dashboard
	{
		public int CenterId { get; set; }

		public string CenterName { get; set; }

		public int TotalBeds { get; set; }

		public int OccupiedBeds { get; set; }

		public int AvailableBeds { get; set; }
	}
}