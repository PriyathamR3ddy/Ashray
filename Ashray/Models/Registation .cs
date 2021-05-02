using Newtonsoft.Json;
using Ashray.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Ashray.Models
{
    public class Registation
    {
        public CentreRegistration cr { get; set; }
        public UserDetail ur { get; set; }

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

        public static int InsertRegistration(Registation egistration)
        {
            int Id = 0;
            try
            {
                using (var db = new AshrayEntities())
                {
                    List<SqlParameter> pram = new List<SqlParameter>();
                    //pram.Add(db.co("@PaymentId", SqlDbType.Int, 0, PaymentId));
                    //Id = db.RunProc("InsertRegistation", pram.ToArray());
                }
            }
            catch (Exception ex)
            {
                Id = 0;

            }



            return Id;
        }

    }

}