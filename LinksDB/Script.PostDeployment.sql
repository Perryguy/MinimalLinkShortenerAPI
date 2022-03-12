/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
if not exists (select 1 from dbo.[Links])
begin 
    insert into dbo.[Links] (LinkName, LinkURL, LinkDescription)
    values ('google', 'https://www.google.com/', 'A link to google'),
    ('yt', 'https://www.youtube.com/', 'A link to youtube'),
    ('reddit', 'https://www.reddit.com/', 'A link to reddit');
end
