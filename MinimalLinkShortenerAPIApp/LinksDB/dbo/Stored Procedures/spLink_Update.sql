CREATE PROCEDURE [dbo].[spLink_Update]
	@Id int,
	@LinkName nvarchar(50),
	@LinkURL nvarchar(300),
	@LinkDescription nvarchar(300),
	@CreatedAt datetime,
	@UpdatedOn datetime

AS
begin
	update dbo.[Links]
	set LinkName = @LinkName, LinkURL = @LinkURL, LinkDescription = @LinkDescription, UpdatedOn = GETDATE() 
	where LinkName = @LinkName;
end

