CREATE TABLE [BFC].[PartyPaymentDetails]
(
	[PPaymentId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [PaymentType] VARCHAR(25) NULL, 
    [TotalAmount] MONEY NULL, 
    [AmountPaid] MONEY NULL, 
    [RemainingAmount] MONEY NULL, 
    [PaymentDate] DATETIME2 NULL, 
    [VendorId] INT NOT NULL,
)
