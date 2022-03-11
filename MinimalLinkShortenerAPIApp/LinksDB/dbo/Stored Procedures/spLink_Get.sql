CREATE PROCEDURE [dbo].[spLink_Get]
	@LinkName nvarchar(50)
AS
begin
	select Id, LinkName, LinkURL, LinkDescription, CreatedAt, UpdatedOn
	from dbo.[Links]
	where LinkName = @LinkName;
end

