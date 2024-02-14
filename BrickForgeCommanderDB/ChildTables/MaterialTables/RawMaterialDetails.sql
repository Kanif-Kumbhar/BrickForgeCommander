CREATE TABLE [BFC].[RawMaterialDetails]
(
	[MaterialId] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [MaterialName] VARCHAR(25) NOT NULL, 
    [Capacity] INT NOT NULL DEFAULT 0,
    [TotalQuantity] INT NOT NULL DEFAULT 0,
    [UnitPrice] MONEY NOT NULL DEFAULT 0
)
