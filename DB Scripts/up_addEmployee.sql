SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


create proc [dbo].[up_addEmployee]
(
@FirstName nvarchar(100),
@LastName nvarchar(100)
)
as

if not exists(select 1 from dbo.Employee where FirstName = @FirstName and LastName = @LastName)
begin
	insert into dbo.Employee(FirstName, LastName)
	values(@FirstName, @LastName)
end


GO


