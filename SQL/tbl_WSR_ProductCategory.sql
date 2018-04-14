USE WholesaleRaja
GO

CREATE TABLE WSR_ProductCategory
(
	[CategoryId] INT IDENTITY(100,1),
	[CategoryName] nVARCHAR(256),
	[IsSubcategory] BIT,
	[ParentCategoryId] INT,
	[IsActive] BIT,
	[CategoryUrl] nVARCHAR(256),
	[SeoTitle] nVARCHAR(256),
	[SeoDescription] nVARCHAR(512),
	[SeoMetaKeywords] nVARCHAR(512),
	[CreatedDate] DATETIME,
	[EnabledDate] DATETIME,
	[UpdatedDate] DATETIME,
	[DisabledDate] DATETIME,
	[CreatedBy] nVARCHAR(256),
	[EnabledBy] nVARCHAR(256),
	[UpdatedBy] nVARCHAR(256),
	[DisabledBy] nVARCHAR(256),

	CONSTRAINT pk_WSR_ProductCategory PRIMARY KEY ([CategoryId])
)