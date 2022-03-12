CREATE PROCEDURE [dbo].[spLink_Search]
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


	select Id, LinkName, LinkURL, LinkDescription, CreatedAt, UpdatedOn, Hits
	from dbo.[Links]
	where LinkName like @LinkName + '%';

end

