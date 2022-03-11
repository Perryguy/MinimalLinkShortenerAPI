CREATE PROCEDURE [dbo].[spLink_GetAll]
AS
begin
	select Id, LinkName, LinkURL, LinkDescription, CreatedAt
	from dbo.[Links];
end
