USE [WholesaleRaja]
GO

CREATE TABLE [WSR_State]
(
	[StateCode] INT IDENTITY(100,1),
	[StateName] nVarchar(256),
	[CountryCode] INT,
	CONSTRAINT PK_WSR_State PRIMARY KEY ([StateCode]),
	CONSTRAINT FK_WSR_State FOREIGN KEY ([CountryCode]) REFERENCES [WSR_Country] ([CountryCode])

)