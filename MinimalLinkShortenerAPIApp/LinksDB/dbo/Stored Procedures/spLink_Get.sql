CREATE PROCEDURE [dbo].[spLink_Get]
	@LinkName nvarchar(50)
AS
begin
	select Id, LinkName, LinkURL, LinkDescription, CreatedAt, UpdatedOn, Hits
	from dbo.[Links]
	where LinkName = @LinkName;
end

