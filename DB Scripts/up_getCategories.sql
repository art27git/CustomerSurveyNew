
/****** Object:  StoredProcedure [dbo].[up_getCategories]    Script Date: 04/02/2014 15:39:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE proc [dbo].[up_getCategories]
(
@ID int = null
)
as

select ID, Name
from dbo.Category
where @ID is null or ID = @ID
order by ID


GO


