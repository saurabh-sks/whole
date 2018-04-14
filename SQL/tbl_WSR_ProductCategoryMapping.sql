USE WholesaleRaja
GO

CREATE TABLE WSR_ProductCategoryMapping
(
	[MappingId] INT IDENTITY(1,1),
	[CategoryId] INT,
	[ProductId] INT,
	[IsActive] BIT,
	[CreatedDate] DATETIME,
	[EnabledDate] DATETIME,
	[UpdatedDate] DATETIME,
	[DisabledDate] DATETIME,
	[CreatedBy] nVARCHAR(256),
	[EnabledBy] nVARCHAR(256),
	[UpdatedBy] nVARCHAR(256),
	[DisabledBy] nVARCHAR(256),

	CONSTRAINT pk_WSR_ProductCategoryMapping PRIMARY KEY ([MappingId])
)