CREATE TABLE [pc].[Return]
(
	ReturnId INT IDENTITY(1,1),
    public List<PurchaseItem> Items { get; set; }
)