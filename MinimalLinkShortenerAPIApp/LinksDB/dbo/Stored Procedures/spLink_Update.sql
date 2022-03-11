CREATE PROCEDURE [dbo].[spLink_Update]
	@LinkName nvarchar(50),
	@LinkURL nvarchar(300),
	@LinkDescription nvarchar(300),
	@UpdatedOn datetime
AS
begin
	update dbo.[Links]
	set LinkName = @LinkName, LinkURL = @LinkURL, LinkDescription = @LinkDescription, UpdatedOn = GETDATE()
	where LinkName = @LinkName;
end

