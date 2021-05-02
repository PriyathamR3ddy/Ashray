using Newtonsoft.Json;
using Ashray.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Ashray;
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

        public static int InsertRegistration(Registation registration)
        {
            int Id = 0;
            try
            {
                using (var db = new AshrayEntities())
                {
                    List<SqlParameter> pram = new List<SqlParameter>();
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@CentreName",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = registration.ControlCentreName
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@ContactPerson",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = registration.PersonName
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@MobileNumber",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = registration.MobileNumber
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@Email",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = registration.EmailAddress
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@BedCount",
                        SqlDbType = System.Data.SqlDbType.Int,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = registration.BedCount
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@LocationId",
                        SqlDbType = System.Data.SqlDbType.Int,                       
                        Direction = System.Data.ParameterDirection.Input,
                        Value = 1
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@StateId",
                        SqlDbType = System.Data.SqlDbType.Int,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = 1
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@Password",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = registration.Password
                    });
                    db.Database.ExecuteSqlCommand("[dbo].[USPInsertUpdateCentreRegistration] @CentreName,@ContactPerson,@MobileNumber,@Email,@BedCount,@LocationId,@StateId,@Password ", pram.ToArray());
                    db.SaveChanges();
                }
            }
            catch(Exception exs)
            {
                Id = 0;

            }
            return Id;
        }

        public static int InsertPatientInfo(PatientInfo patientInfo)
        {
            int Id = 0;
            try
            {
                using (var db = new AshrayEntities())
                {
                    List<SqlParameter> pram = new List<SqlParameter>();
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@PatientName",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientInfo.PatientName
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@RTPCRTestNumber",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientInfo.RTPCRTestNumber
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@TestResult",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientInfo.TestResult
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@GovtIdNumber",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientInfo.GovtIdNumber
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@PatientAddress",
                        SqlDbType = System.Data.SqlDbType.Int,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientInfo.PatientAddress
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@Gender",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientInfo.Gender
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@EmergencyContactName1",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientInfo.EmergencyContactName1
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@EmergencyContactNumber1",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientInfo.EmergencyContactNumber1
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@EmergencyContactName2",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientInfo.EmergencyContactName2
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@EmergencyContactNumber2",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientInfo.EmergencyContactNumber2
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@CentreId",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientInfo.CentreId
                    });
                    db.Database.ExecuteSqlCommand("[dbo].[USPInsertUpdatePatientInfo]  @PatientName,@RTPCRTestNumber,@TestResult,@GovtIdNumber,@PatientAddress,@Gender,@EmergencyContactName1,@EmergencyContactNumber1 ,@EmergencyContactName2,@EmergencyContactNumber2,@CentreId", pram.ToArray());
                    db.SaveChanges();
                }
            }
            catch (Exception exs)
            {
                Id = 0;

            }
            return Id;
        }
    }

}