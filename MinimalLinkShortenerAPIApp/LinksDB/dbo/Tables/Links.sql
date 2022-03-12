﻿CREATE TABLE [dbo].[Links]
(
	[Id] INT NOT NULL PRIMARY KEY  IDENTITY, 
    [LinkName] NVARCHAR(50) NOT NULL UNIQUE , 
    [LinkURL] NVARCHAR(300) NOT NULL, 
    [LinkDescription] NVARCHAR(300) NULL, 
    [CreatedAt] DATETIME NOT NULL DEFAULT GETDATE(), 
    [UpdatedOn] DATETIME NOT NULL DEFAULT GETDATE(), 
    [Hits] INT NOT NULL DEFAULT 0 
)

GO CREATE INDEX [LinkName_Index] ON [dbo].[Links] ([LinkName])

