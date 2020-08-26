CREATE TABLE [pc].[Purchase]
(
	[PurchaseId] INT IDENTITY(1,1),
    [DeliveryAddress] VARCHAR(500),
    [ReceipmentPhone] VARCHAR(500),
    [Status] VARCHAR(100),
    public Return Return { get; set; }
    public List<Delivery> Delivery { get; set; }
)