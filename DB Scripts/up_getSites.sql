/****** Object:  StoredProcedure [dbo].[up_getSites]    Script Date: 04/02/2014 15:40:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[up_getSites]
(
@ID int = null
)
as

select S.ID, S.DomainName, S.CategoryID, C.Name AS Category, S.PageRank, S.DomainAuthority, S.PostingSpeed, S.Cost, S.Details, S.Notes
from dbo.Site S
inner join dbo.Category C
on C.ID = S.CategoryID
where @ID is null or S.ID = @ID
order by S.ID desc


GO


