CREATE PROCEDURE [dbo].[spLink_GetAll]
AS
begin
	select Id, LinkName, LinkURL, LinkDescription, CreatedAt, UpdatedOn
	from dbo.[Links];
end
