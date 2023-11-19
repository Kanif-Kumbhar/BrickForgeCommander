CREATE TABLE [kanif].[ProductDetails]
(
	[ProductId] INT NOT NULL PRIMARY KEY, 
    [MaterialId] INT NOT NULL, 
    [ProductName] NVARCHAR(50) NOT NULL, 
    [unitPrice] DECIMAL(12, 2) NOT NULL, 
    [ScoreId] INT NOT NULL, 
    [ClassTypeId] NCHAR(10) NOT NULL, 
    [isDiscontiuned] BIT NOT NULL
)
