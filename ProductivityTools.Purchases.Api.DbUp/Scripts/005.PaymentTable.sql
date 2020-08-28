CREATE TABLE [pc].[Payment]
(
	PaymentId INT IDENTITY(1,1),
	[Date] Date,
    [Amount] decimal,
    [Type] VARCHAR(20),
    [Status] VARCHAR(200),

    [PurchaseId] INT,

    CONSTRAINT PK_Payment PRIMARY KEY (PaymentId),
    CONSTRAINT FK_PaymentPurchase FOREIGN KEY (PurchaseId) REFERENCES [pc].Purchase(PurchaseId)
)