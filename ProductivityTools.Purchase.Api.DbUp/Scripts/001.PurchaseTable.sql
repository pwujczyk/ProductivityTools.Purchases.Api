CREATE SCHEMA [PC];

CREATE TABLE [Purchase]
(
	PurchaseId INT IDENTITY(1,1),
	[value] DECIMAL (5,2),
	CreationDate DATE,

)