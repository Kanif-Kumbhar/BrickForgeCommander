CREATE TABLE [BFC].[StockReports]
(
	[ReportId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [MaterialId] INT NOT NULL, 
    [Quantity] INT NOT NULL, 
    [PurchasePrice] MONEY NOT NULL, 
    [UnitPrice] MONEY NULL, 
    [StockStatus] VARCHAR(25) NOT NULL, 
    [DateReported] DATETIME2 NULL, 
    CONSTRAINT [FK_StockReports_RawMaterialDetails] FOREIGN KEY ([MaterialId]) REFERENCES [BFC].[RawMaterialDetails]([MaterialId])
)
