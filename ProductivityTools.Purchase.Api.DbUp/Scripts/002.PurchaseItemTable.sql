CREATE TABLE [pc].[PurchaseItem]
(
	[PurchaseItemId] INT IDENTITY(1,1),
	[Name] VARCHAR(400),
	[SinglePrice] DECIMAL(6,2),
	[Amount] INT
)