CREATE TABLE [pc].[Dealer]
(
	[DealerId] INT IDENTITY(1,1),
    [Name] VARCHAR(100),
    [Address] VARCHAR(400),
    [Phone] VARCHAR(15),
    [Email] VARCHAR(100),
    [PurchaseId] INT,

    CONSTRAINT PK_Dealer PRIMARY KEY (DealerId),
    CONSTRAINT FK_DealerPurchase FOREIGN KEY (PurchaseId) REFERENCES [pc].Purchase(PurchaseId)
)