﻿CREATE PROCEDURE [dbo].[spLink_Get]
	@LinkName nvarchar(50)
AS
begin

	Update dbo.[Links]
		Set Hits =
			(Case
				When LinkName = @LinkName Then Hits + 1
				Else Hits
				End
			)

	select LinkURL
	from dbo.[Links]
	where LinkName = @LinkName;

end
