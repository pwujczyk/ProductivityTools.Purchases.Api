CREATE TABLE [pc].[Payment]
(
	PaymentId INT IDENTITY(1,1),
	[Date] Date,
    [Amount] decimal,
    [Type] VARCHAR(20),
    [Status] VARCHAR(200)
)