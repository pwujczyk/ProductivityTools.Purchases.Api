CREATE TABLE [ps].Purchase(

	PurchaseId int IDENTITY(1,1),
	Description VARCHAR(100),
	Amount DECIMAL(5,2),
	[Comment] VARCHAR(1000),
	
	CONSTRAINT  PK_PurchaseId PRIMARY KEY (PurchaseId)
)