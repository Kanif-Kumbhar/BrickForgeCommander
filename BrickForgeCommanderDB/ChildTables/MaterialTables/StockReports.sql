CREATE TABLE [BFC].[StockReports]
(
	[ReportId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [MaterialId] INT NOT NULL, 
    [SupplierId] INT NOT NULL, 
    [Quantity] INT NOT NULL, 
    [PurchasePrice] MONEY NOT NULL, 
    [StockStatus] VARCHAR(25) NOT NULL, 
    [DateReported] DATETIME2 NULL, 
    CONSTRAINT [FK_StockReports_RawMaterialDetails] FOREIGN KEY ([MaterialId]) REFERENCES [BFC].[RawMaterialDetails]([MaterialId]),
    CONSTRAINT [FK_StockReports_SupplierDetails] FOREIGN KEY ([SupplierId]) REFERENCES [BFC].[VendorDetails]([VendorId])
)
