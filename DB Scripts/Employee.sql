USE [CustomerSurvey]
GO

/****** Object:  Table [dbo].[Employee]    Script Date: 05/08/2015 12:19:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[UserCreated] [nvarchar](40) NOT NULL,
	[UserModified] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [Employee_DateCreated]  DEFAULT (getutcdate()) FOR [DateCreated]
GO

ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [Employee_DateModified]  DEFAULT (getutcdate()) FOR [DateModified]
GO

ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [Employee_UserCreated]  DEFAULT (suser_sname()) FOR [UserCreated]
GO

ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [Employee_UserModified]  DEFAULT (suser_sname()) FOR [UserModified]
GO


