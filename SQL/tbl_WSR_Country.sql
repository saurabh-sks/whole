USE [WholesaleRaja]
GO

CREATE TABLE [WSR_Country]
(
	[CountryCode] INT IDENTITY(1,1),
	[CountryName] nVarchar(256),

	CONSTRAINT PK_WSR_Country PRIMARY KEY ([CountryCode])

)