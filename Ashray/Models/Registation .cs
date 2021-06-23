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
                        SqlDbType = System.Data.SqlDbType.VarChar,
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
                        SqlDbType = System.Data.SqlDbType.Int,                      
                        Direction = System.Data.ParameterDirection.Input,
                        Value = 1
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@PatientPhoneNumber",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 15,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientInfo.PatientPhoneNumber
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@EmergencyContactRelationShip1",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 20,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientInfo.EmergencyContactRelationShip1
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@EmergencyContactRelationShip2",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 20,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientInfo.EmergencyContactRelationShip2
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@RTPCRTestDate",
                        SqlDbType = System.Data.SqlDbType.DateTime,                       
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientInfo.RTPCRTestDate
                    });                    
                    db.Database.ExecuteSqlCommand("[dbo].[USPInsertUpdatePatientInfo]  @PatientName,@RTPCRTestNumber,@TestResult,@GovtIdNumber,@PatientAddress,@Gender,@EmergencyContactName1,@EmergencyContactNumber1 ,@EmergencyContactName2,@EmergencyContactNumber2,@CentreId,@PatientPhoneNumber,@EmergencyContactRelationShip1,@EmergencyContactRelationShip2,@RTPCRTestDate", pram.ToArray());
                    db.SaveChanges();
                }
            }
            catch (Exception exs)
            {
                Id = 0;

            }
            return Id;
        }

        public static Dashboard GetDashboard()
        {
            Dashboard dashboard;
            try
            {
                using (var db = new AshrayEntities())
                {
                    List<SqlParameter> pram = new List<SqlParameter>();
                    dashboard  =  db.Database.SqlQuery<Dashboard>("[dbo].[USPBedAvailabilityDashboardInfo]", pram.ToArray()).ToList()[0];                    
                }
            }
            catch (Exception exs)
            {
                dashboard = null;
            }
            return dashboard;
        }

        public static int InsertPatientHistory(PatientHistory patientHistory)
        {
            int Id = 0;
            try
            {
                patientHistory.PatientDocumentPath = string.IsNullOrEmpty(patientHistory.PatientDocumentPath) ? "" : patientHistory.PatientDocumentPath;
				if (patientHistory.CheckoutDatetime == null)
				{
                    patientHistory.CheckoutDatetime = Convert.ToDateTime("01/01/1900");
                }
				using (var db = new AshrayEntities())
                {
                    List<SqlParameter> pram = new List<SqlParameter>();
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@PatientId",
                        SqlDbType = System.Data.SqlDbType.Int,                        
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientHistory.PatientInfo.PatientId
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@CheckinDateTime",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientHistory.CheckinDateTime
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@CheckoutDatetime",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientHistory.CheckoutDatetime
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@DischargeInfo",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 250,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientHistory.DischargeInfo
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@PatientDocumentPath",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 200,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientHistory.PatientDocumentPath
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@RoomNumber",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 20,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientHistory.RoomNumber
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@BedNumber",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 20,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientHistory.BedNumber
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@BP",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientHistory.BP
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@SPO2",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientHistory.SPO2
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@Temperature",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientHistory.Temperature
                    });
                    db.Database.ExecuteSqlCommand("[dbo].[USPInsertPatientHistory]  @PatientId,@CheckinDateTime,@CheckoutDatetime,@DischargeInfo,@PatientDocumentPath,@RoomNumber,@BedNumber,@BP,@SPO2,@Temperature", pram.ToArray());
                    db.SaveChanges();
                }
            }
            catch (Exception exs)
            {
                Id = 0;

            }
            return Id;
        }

        public static List<PostHospital> GetPosthospitalInfo()
        {
            List<PostHospital> postHospital;
            try
            {
                using (var db = new AshrayEntities())
                {
                    List<SqlParameter> pram = new List<SqlParameter>();
                    postHospital = db.Database.SqlQuery<PostHospital>("[dbo].[USPGetPostHospitalInfo]", pram.ToArray()).ToList();
                }
            }
            catch (Exception exs)
            {
                postHospital = null;
            }
            return postHospital;
        }

        public static List<BedTypes> GetBedTypeInfo()
        {
            List<BedTypes> bedTypes;
            try
            {
                using (var db = new AshrayEntities())
                {
                    List<SqlParameter> pram = new List<SqlParameter>();
                    bedTypes = db.Database.SqlQuery<BedTypes>("[dbo].[USPGetBedTypeInfo]", pram.ToArray()).ToList();
                }
            }
            catch (Exception exs)
            {
                bedTypes = null;
            }
            return bedTypes;
        }

        public static PatientHistory GetPatientHistory(int patientId)
        {
            PatientHistory patientHistory;
            try
            {
                using (var db = new AshrayEntities())
                {
                    List<SqlParameter> pram = new List<SqlParameter>();
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@PatientId",
                        SqlDbType = System.Data.SqlDbType.Int,                      
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientId
                    });
                    patientHistory = db.Database.SqlQuery<PatientHistory>("[dbo].[USPGetPatientHistory] @PatientId", pram.ToArray()).ToList()[0];
                }
            }
            catch (Exception exs)
            {
                patientHistory = null;
            }
            return patientHistory;
        }

        public static HomeDashboard GetHomeDashboard()
        {
            HomeDashboard dashboard;
            try
            {
                using (var db = new AshrayEntities())
                {
                    List<SqlParameter> pram = new List<SqlParameter>();
                    dashboard = db.Database.SqlQuery<HomeDashboard>("[dbo].[USPBedAvailabilityHomeDashboardInfo]", pram.ToArray()).ToList()[0];
                }
            }
            catch (Exception exs)
            {
                dashboard = null;
            }
            return dashboard;
        }

        public static Login ValidateLoginInfo(Login login)
        {
            Login result;
            try
            {
                using (var db = new AshrayEntities())
                {
                    List<SqlParameter> pram = new List<SqlParameter>();
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@Email",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 100,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = login.Email
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@Password",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = login.Password
                    });
                    result = db.Database.SqlQuery<Login>("[dbo].[USPValidateLoginInfo] @Email,@Password", pram.ToArray()).ToList()[0];
                }
            }
            catch (Exception exs)
            {
                result = null;
            }
            return result;
        }

        public static int DeletePatientInfo(int patientId, int patientStatus)
        {
            int Id = 0;
            try
            {
                using (var db = new AshrayEntities())
                {
                    List<SqlParameter> pram = new List<SqlParameter>();
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@patientId",
                        SqlDbType = System.Data.SqlDbType.Int,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientId
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@PatientStatus",
                        SqlDbType = System.Data.SqlDbType.Int,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = patientStatus
                    });
                    Id =  db.Database.ExecuteSqlCommand("[dbo].[USPDeletePatientInfo]  @patientId,@PatientStatus", pram.ToArray());
                    db.SaveChanges();
                }
            }
            catch (Exception exs)
            {
                Id = 0;
            }
            return Id;
        }

        public static List<PatientDashboard> GetPatientHomeDashboard()
        {
            List<PatientDashboard> patientDashboard;
            try
            {
                using (var db = new AshrayEntities())
                {
                    List<SqlParameter> pram = new List<SqlParameter>();
                    patientDashboard = db.Database.SqlQuery<PatientDashboard>("[dbo].[GetPatientHomePageDashboard]", pram.ToArray()).ToList();
                    db.SaveChanges();
                }
            }
            catch (Exception exs)
            {
                patientDashboard = null;
            }
            return patientDashboard;
        }

        public static bool InsertVaccieDetails(VaccinationModel vaccinationModel)
        {
            bool result;
            try
            {
                using (var db = new AshrayEntities())
                {
                    List<SqlParameter> pram = new List<SqlParameter>();
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@EmpCode",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 20,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = vaccinationModel.EmpCode
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@EmpLocation",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 50,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = vaccinationModel.Location
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@Vaccinated",
                        SqlDbType = System.Data.SqlDbType.Bit,                       
                        Direction = System.Data.ParameterDirection.Input,
                        Value = vaccinationModel.Vaccinated
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@FeedingMother",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = vaccinationModel.ReasonforVacc
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@CovidCheck",
                        SqlDbType = System.Data.SqlDbType.Bit,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = 0
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@VaccineInfections",
                        SqlDbType = System.Data.SqlDbType.Bit,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = 0
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@WillingToVaccine",
                        SqlDbType = System.Data.SqlDbType.Bit,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = vaccinationModel.WillingToVaccine
                    });
                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@TentativeDate",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Direction = System.Data.ParameterDirection.Input,
                        Value = vaccinationModel.NearestCluster
                    });
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("PersonName", typeof(string));
                    dataTable.Columns.Add("DateOfVaccination", typeof(DateTime));
                    dataTable.Columns.Add("DoseTaken", typeof(string));
                    dataTable.Columns.Add("VaccineName", typeof(string));
                    dataTable.Columns.Add("Relation", typeof(string));
                    dataTable.Columns.Add("DueDate", typeof(DateTime));

					foreach (var item in vaccinationModel.EmpVaccineDetails)
					{
                        DataRow dr = dataTable.NewRow();
                        dr[0] = item.PersonName;
                        dr[1] = item.DateOfVaccination;
                        dr[2] = item.DoseTaken;
                        dr[3] = item.VaccineName;
                        dr[4] = item.Relation;
                        dr[5] = item.DueDate;
                        dataTable.Rows.Add(dr);
					}

                    pram.Add(new SqlParameter()
                    {
                        ParameterName = "@EmployeeVaccineDetails",
                        SqlDbType = System.Data.SqlDbType.Structured,
                        Direction = System.Data.ParameterDirection.Input,
                        TypeName = "dbo.EmployeeVaccineDetails",
                        Value = dataTable
                    }); 

                    int row = db.Database.ExecuteSqlCommand("[USP_InsertVaccineInfo] @EmpCode,@EmpLocation,@Vaccinated,@FeedingMother,@CovidCheck,@VaccineInfections,@WillingToVaccine,@TentativeDate,@EmployeeVaccineDetails", pram.ToArray());
                    result = true;
                }
            }
            catch (Exception exs)
            {
                result = false;
            }
            return result;
        }
    }
}