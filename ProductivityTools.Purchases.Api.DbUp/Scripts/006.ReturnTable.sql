CREATE TABLE [pc].[Return]
(
	ReturnId INT IDENTITY(1,1),
	[PurchaseId] INT,

    CONSTRAINT FK_ReturnPurchase FOREIGN KEY (PurchaseId) REFERENCES Purchase(PurchaseId)
)