CREATE TABLE [pc].[PurchaseItem]
(
	[PurchaseItemId] INT IDENTITY(1,1),
	[Name] VARCHAR(400),
	[SinglePrice] DECIMAL(6,2),
	[Amount] INT,
	[PurchaseId] INT,
	[ReturnId] INT,

	CONSTRAINT PK_PurchaseItem PRIMARY KEY ([PurchaseItemId]),
	CONSTRAINT FK_PurchaseItemPurchase FOREIGN KEY (PurchaseId) REFERENCES [pc].[Purchase](PurchaseId)
)