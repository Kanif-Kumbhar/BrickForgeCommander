CREATE TABLE [kanif].[OrderDetails]
(
	[OrderDetailId] INT NOT NULL PRIMARY KEY, 
    [OrderId] INT NOT NULL, 
    [ProductId] INT NOT NULL, 
    [UnitPrice] DECIMAL(12, 2) NOT NULL, 
    [Quantity] INT NOT NULL, 
    [Margin] DECIMAL(5, 2) NOT NULL
)
