alter table PatientInfo add PatientPhoneNumber varchar(15) NULL
alter table PatientInfo Add EmergencyContactRelationShip1 VARCHAR(20) NULL
alter table PatientInfo Add EmergencyContactRelationShip2 VARCHAR(20) NULL
alter table PatientInfo Add RTPCRTestDate DATETIME NULL
go

CREATE PROC [dbo].[USPDeletePatientInfo]     
(    
@patientId INT
)    
AS    
BEGIN    
 delete from PatientHistory where PatientId = @patientId
 delete from PatientInfo where PatientId = @patientId
END    

go    

ALTER PROC [dbo].[USPInsertUpdatePatientInfo]     
(    
@PatientName VARCHAR(50),    
@RTPCRTestNumber VARCHAR(25),    
@TestResult VARCHAR(10),    
@GovtIdNumber VARCHAR(50),    
@PatientAddress VARCHAR(100),    
@Gender VARCHAR(10),    
@EmergencyContactName1 VARCHAR(50),    
@EmergencyContactNumber1 VARCHAR(50),    
@EmergencyContactName2 VARCHAR(50),    
@EmergencyContactNumber2 VARCHAR(50),    
@CentreId INT,
@PatientPhoneNumber varchar(15)=NULL,
@EmergencyContactRelationShip1 VARCHAR(20)=NULL,
@EmergencyContactRelationShip2 VARCHAR(20)=NULL,
@RTPCRTestDate DATETIME NULL
)    
AS    
BEGIN    
 INSERT INTO PatientInfo(PatientName,RTPCRTestNumber,TestResult,    
 GovtIdNumber,PatientAddress,Gender,EmergencyContactName1,    
 EmergencyContactNumber1,EmergencyContactName2,EmergencyContactNumber2,    
 DateTime,CentreId,PatientPhoneNumber,EmergencyContactRelationShip1,EmergencyContactRelationShip2,RTPCRTestDate) VALUES    
 (@PatientName,@RTPCRTestNumber,@TestResult,@GovtIdNumber,    
 @PatientAddress,@Gender,@EmergencyContactName1,    
 @EmergencyContactNumber1,@EmergencyContactName2,    
 @EmergencyContactNumber2,GETDATE(),@CentreId,@PatientPhoneNumber,@EmergencyContactRelationShip1,@EmergencyContactRelationShip2,@RTPCRTestDate)  
 declare @patientId int  
 SET @patientId  = scope_identity()   
 Insert into Patienthistory(PatientId,checkindatetime)  values(@patientId,null)  
END    
    