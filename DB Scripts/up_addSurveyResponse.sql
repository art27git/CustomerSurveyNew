SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[up_addSurveyResponse]
(
@EmployeeID int,
@Rating varchar(20),
@HospitalName varchar(255) = null,
@Comments nvarchar(max) = null,
@CallBack bit = 0
)
as

insert into dbo.SurveyResponse(EmployeeID, Rating, HospitalName, Comments, CallBack)
	values(@EmployeeID, @Rating, @HospitalName, @Comments, @CallBack)

GO


