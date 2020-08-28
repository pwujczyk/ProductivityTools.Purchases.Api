CREATE TABLE [pc].[Purchase]
(
	[PurchaseId] INT IDENTITY(1,1),
    [DeliveryAddress] VARCHAR(500),
    [ReceipmentPhone] VARCHAR(500),
    [Status] VARCHAR(100),
    [ReturnNumber] VARCHAR(500),

    CONSTRAINT PK_Purchase PRIMARY KEY (PurchaseId)
)