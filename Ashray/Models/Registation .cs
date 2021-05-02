using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ashray.Models
{
    public class Registation
    {
        [JsonProperty(PropertyName = "controlCentreName")]
        public string ControlCentreName { get; set; }

        [JsonProperty(PropertyName = "personName")]
        public string PersonName { get; set; }

        [JsonProperty(PropertyName = "mobileNumber")]
        public string MobileNumber { get; set; }

        [JsonProperty(PropertyName = "emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        [JsonProperty(PropertyName = "confirmPassword")]
        public string ConfirmPassword { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        [JsonProperty(PropertyName = "pincode")]
        public int Pincode { get; set; }

        [JsonProperty(PropertyName = "bedCount")]
        public int BedCount { get; set; }
    }
}