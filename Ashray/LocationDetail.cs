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
    
    public partial class LocationDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LocationDetail()
        {
            this.CentreRegistrations = new HashSet<CentreRegistration>();
        }
    
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string LocationPinCode { get; set; }
        public Nullable<int> StateId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CentreRegistration> CentreRegistrations { get; set; }
        public virtual StateDetail StateDetail { get; set; }
    }
}
