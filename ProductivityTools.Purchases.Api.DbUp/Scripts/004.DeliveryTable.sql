CREATE TABLE [pc].[Delivery]
(
	DeliveryId INT IDENTITY(1,1),
    [Date] Date,
    Number VARCHAR(20),
    Status VARCHAR(100),
    PurchaseId INT,

    CONSTRAINT PK_Delivery PRIMARY KEY (DeliveryId),
    CONSTRAINT FK_DeliveryPurchase FOREIGN KEY (PurchaseId) REFERENCES [pc].Purchase(PurchaseId),
)