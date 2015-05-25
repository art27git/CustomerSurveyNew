USE [dbec47fe2bf55b4a4bbb95a49e016e8f8e]
GO

/****** Object:  StoredProcedure [dbo].[up_getEmployees]    Script Date: 05/25/2015 17:48:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE proc [dbo].[up_getEmployees]
as

select ID, FirstName, LastName
from dbo.Employee
order by FirstName, LastName

GO


