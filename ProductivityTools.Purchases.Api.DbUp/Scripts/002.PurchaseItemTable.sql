CREATE TABLE [pc].[PurchaseItem]
(
	[PurchaseItemId] INT IDENTITY(1,1),
	[Name] VARCHAR(400),
	[SinglePrice] DECIMAL(6,2),
	[Amount] INT,
	[Price] DECIMAL (6,2),
	[ReturnedAmount] INT,
	[ReturnedPrice] DECIMAL(6,2),

	[PurchaseId] INT,
	[ReturnId] INT,

	CONSTRAINT PK_PurchaseItem PRIMARY KEY ([PurchaseItemId]),
	CONSTRAINT FK_PurchaseItemPurchase FOREIGN KEY (PurchaseId) REFERENCES [pc].[Purchase](PurchaseId)
)