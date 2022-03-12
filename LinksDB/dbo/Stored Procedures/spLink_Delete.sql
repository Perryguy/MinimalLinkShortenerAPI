CREATE PROCEDURE [dbo].[spLink_Delete]
	@LinkName nvarchar(50)
AS
begin
	delete
	from dbo.[Links]
	where LinkName = @LinkName;
end
