CREATE TABLE [pc].[Purchase]
(
	[PurchaseId] INT IDENTITY(1,1),
    [DeliveryAddress] VARCHAR(500),
    [ReceipmentPhone] VARCHAR(500),
    [Status] VARCHAR(100),
    public List<PurchaseItem> Items { get; set; }
    public Dealer Dealer { get; set; }
    public Payment Payment { get; set; }
    public Return Return { get; set; }
    public List<Delivery> Delivery { get; set; }
)