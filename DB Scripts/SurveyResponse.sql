/****** Object:  Table [dbo].[SurveyResponse]    Script Date: 05/25/2015 17:38:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[SurveyResponse](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[Rating] [varchar](20) NOT NULL,
	[HospitalName] [varchar](255) NULL,
	[Comments] [nvarchar](max) NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
	[UserCreated] [nvarchar](40) NOT NULL,
	[UserModified] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_SurveyResponse] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[SurveyResponse]  WITH CHECK ADD  CONSTRAINT [FK_SurveyResponse_Employee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([ID])
GO

ALTER TABLE [dbo].[SurveyResponse] CHECK CONSTRAINT [FK_SurveyResponse_Employee]
GO

ALTER TABLE [dbo].[SurveyResponse] ADD  CONSTRAINT [SurveyResponse_DateCreated]  DEFAULT (getutcdate()) FOR [DateCreated]
GO

ALTER TABLE [dbo].[SurveyResponse] ADD  CONSTRAINT [SurveyResponse_DateModified]  DEFAULT (getutcdate()) FOR [DateModified]
GO

ALTER TABLE [dbo].[SurveyResponse] ADD  CONSTRAINT [SurveyResponse_UserCreated]  DEFAULT (suser_sname()) FOR [UserCreated]
GO

ALTER TABLE [dbo].[SurveyResponse] ADD  CONSTRAINT [SurveyResponse_UserModified]  DEFAULT (suser_sname()) FOR [UserModified]
GO


