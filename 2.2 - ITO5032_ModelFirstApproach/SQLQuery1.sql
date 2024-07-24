﻿CREATE TABLE [dbo].[Students] (
	[Id] INT IDENTITY(1,1) NOT NULL,
	[FirstName] nvarchar(max) NOT NULL,
	[LastName] nvarchar(max) NOT NULL,
	PRIMARY KEY (Id)
);
GO

CREATE TABLE [dbo].[Units] (
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Name] nvarchar(max) NOT NULL,
	[Description] nvarchar(max) NOT NULL,
	[StudentId] INT NOT NULL,
	PRIMARY KEY (Id), 
	FOREIGN KEY (StudentId) REFERENCES Students(Id)
);
GO