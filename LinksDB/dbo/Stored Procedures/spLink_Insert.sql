CREATE PROCEDURE [dbo].[spLink_Insert]
	@LinkName nvarchar(50),
	@LinkURL nvarchar(300),
	@LinkDescription nvarchar(300)
AS
begin
	insert into dbo.[Links] (LinkName, LinkURL, LinkDescription)
	values (@LinkName, @LinkURL, @LinkDescription);
end
