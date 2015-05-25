SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[up_getSurveyResponses]
as

select SR.ID
, SR.Rating
, SR.HospitalName
, SR.Comments
, E.FirstName + ' ' + E.LastName AS EmployeeName
from dbo.SurveyResponse SR
inner join dbo.Employee E
on E.ID = SR.EmployeeID
order by SR.DateCreated desc


GO


