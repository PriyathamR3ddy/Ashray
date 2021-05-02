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
    using System;
    using System.Collections.Generic;
    
    public partial class PatientInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PatientInfo()
        {
            this.PatientHistories = new HashSet<PatientHistory>();
        }
    
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public string RTPCRTestNumber { get; set; }
        public string TestResult { get; set; }
        public string GovtIdNumber { get; set; }
        public string PatientAddress { get; set; }
        public string Gender { get; set; }
        public string EmergencyContactName1 { get; set; }
        public string EmergencyContactNumber1 { get; set; }
        public string EmergencyContactName2 { get; set; }
        public string EmergencyContactNumber2 { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public Nullable<int> CentreId { get; set; }
    
        public virtual CentreRegistration CentreRegistration { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientHistory> PatientHistories { get; set; }
    }
}
