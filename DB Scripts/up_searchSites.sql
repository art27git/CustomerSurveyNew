/****** Object:  StoredProcedure [dbo].[up_searchSites]    Script Date: 04/02/2014 15:40:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[up_searchSites]
(
@CategoryID int = null,
@PageRankMin smallint = null,
@PageRankMax smallint = null,
@DomainAuthorityMin int = null,
@DomainAuthorityMax int = null,
@PostingSpeed nvarchar(10) = null,
@CostMin int = null,
@CostMax int = null
)
as

select ID, DomainName, CategoryID, PageRank, DomainAuthority, PostingSpeed, Cost, Details, Notes
from dbo.Site
where (@CategoryID is null or CategoryID = @CategoryID)
and (@PageRankMin is null or PageRank >= @PageRankMin)
and (@PageRankMax is null or PageRank <= @PageRankMax)
and (@DomainAuthorityMin is null or DomainAuthority >= @DomainAuthorityMin)
and (@DomainAuthorityMax is null or DomainAuthority <= @DomainAuthorityMax)
and (@PostingSpeed is null or PostingSpeed = @PostingSpeed)
and (@CostMin is null or Cost >= @CostMin)
and (@CostMax is null or Cost <= @CostMax)


GO


