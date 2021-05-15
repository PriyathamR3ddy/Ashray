//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ashray
{
	using Ashray.Models;
	using System;
    using System.Collections.Generic;
    
    public partial class PatientHistory
    {
        public int HistoryId { get; set; }
        public Nullable<int> PatientId { get; set; }
        public Nullable<System.DateTime> CheckinDateTime { get; set; }
        public Nullable<System.DateTime> CheckoutDatetime { get; set; }
        public string DischargeInfo { get; set; }
        public string BP { get; set; }
        public string SPO2 { get; set; }
        public string Temperature { get; set; }
        public string PatientDocumentPath { get; set; }
        public string RoomNumber { get; set; }
        public string BedNumber { get; set; }

        public string EmergencyContactName1 { get; set; }

        public string EmergencyContactNumber1 { get; set; }

        public virtual PatientInfo PatientInfo { get; set; }

        public List<FileUpload> Files { get; set; }

    }
}
