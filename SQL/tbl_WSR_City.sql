USE [WholesaleRaja]
GO

CREATE TABLE [WSR_City]
(
	[CityCode] INT IDENTITY(1000,1),
	[CityName] nVarchar(256),
	[StateCode] INT, 

	CONSTRAINT PK_WSR_City PRIMARY KEY ([CityCode]),
	CONSTRAINT FK_WSR_City FOREIGN KEY ([StateCode]) REFERENCES [WSR_State] ([StateCode])

)