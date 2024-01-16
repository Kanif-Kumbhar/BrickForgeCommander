CREATE TABLE [BFC].[ProductDetails]
(
	[ProductId] INT NOT NULL PRIMARY KEY Identity(1,1), 
    [MaterialId] INT NOT NULL, 
    [ProductName] NVARCHAR(50) NOT NULL, 
    [unitPrice] DECIMAL(12, 2) NOT NULL, 
    [ScoreId] INT NOT NULL, 
    [ClassTypeId] NCHAR(10) NOT NULL, 
    [isDiscontinued] BIT NOT NULL, 
    [Stock] INT NOT NULL
)
