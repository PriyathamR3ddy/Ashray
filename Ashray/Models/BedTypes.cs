using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ashray.Models
{
	public class BedTypes
	{
		public string CenterName { get; set; }
		public string Location { get; set; }
		public int IsolationBed { get; set; }

		public int Oxygen { get; set; }
		public int ICUBed { get; set; }
	}
}