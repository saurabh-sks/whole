CREATE TABLE [WSR_UserInfo]
(
	[UserId] UniqueIdentifier,
	[UserName] nVARCHAR(256) NOT NULL,
	[FirstName] nVARCHAR(256),
	[MiddleName] nVARCHAR(256),
	[LastName] nVARCHAR(256),
	[Email] nVARCHAR(256),
	[MobileNumber] nVARCHAR(15),
	[AddressLine1] VARCHAR(200),
	[AddressLine2] VARCHAR(200),
	[City] VARCHAR(100),
	[State] VARCHAR(100),
	[Country] VARCHAR(100),
	[PinCode] VARCHAR(10),

	CONSTRAINT PK_WSR_UserInfo PRIMARY KEY ([UserId]),
	CONSTRAINT FK_WSR_UserInfo FOREIGN KEY ([UserId]) REFERENCES aspnet_Users([UserId])

)