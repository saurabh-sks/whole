USE WholesaleRaja
GO

CREATE TABLE [WSR_Product]
(
	[ProductId] INT IDENTITY(1,1),
	[Name] nVARCHAR(256) NOT NULL,
	[Image] nVARCHAR(256),
	[SKU] nVARCHAR(256) NOT NULL,
	[IsActive] BIT,
	[Description] nVARCHAR(512),
	[BasePrice] MONEY NOT NULL,
	[SalePrice] MONEY,
	[SavingsAmount] MONEY,
	[SavingsPercentage] INT,
	[BasePriceString] nVARCHAR(256),
	[SalePriceString] nVARCHAR(256),
	[SavingsAmountString] nVARCHAR(256),
	[SeoTitle] nVARCHAR(256),
	[SeoDescription] nVARCHAR(512),
	[SeoMetaKeywords] nVARCHAR(512),
	[CreatedDate] DATETIME,
	[UpdatedDate] DATETIME,
	[DisabledDate] DATETIME,
	[CreatedBy] nVARCHAR(256),
	[UpdatedBy] nVARCHAR(256),
	[DisabledBy] nVARCHAR(256),

	CONSTRAINT pk_WSR_Product PRIMARY KEY ([ProductId]),
)