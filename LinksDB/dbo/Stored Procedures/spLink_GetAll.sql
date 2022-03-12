CREATE PROCEDURE [dbo].[spLink_GetAll]
AS
begin
	select Id, LinkName, LinkURL, LinkDescription, CreatedAt, UpdatedOn, Hits
	from dbo.[Links];
end
