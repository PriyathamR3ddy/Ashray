using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ashray.Models
{
    public class VaccinationModel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public bool Vaccinated { get; set; }
        public string VaccinatedDate { get; set; }
        public int DoseTaken { get; set; }
        public string VaccineName { get; set; }
        public string Relation { get; set; }
        public string DueDate { get; set; }
    }
}