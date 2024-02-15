CREATE TABLE [BFC].[ProductDetails]
(
	[ProductId] INT NOT NULL PRIMARY KEY Identity(1,1), 
    [BrickId] INT NOT NULL, 
    [UnitPrice] DECIMAL(12, 2) NOT NULL, 
    [ProfitMargin] DECIMAL(12, 2) NOT NULL,
    [TotalAmount] MONEY NOT NULL,
    [ScoreId] INT NOT NULL, 
    [isDiscontinued] BIT NOT NULL DEFAULT 1, 
    [Stock] INT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_ProductDetails_BrickDetails] FOREIGN KEY ([BrickId]) REFERENCES [BFC].[BrickDetails]([BrickId])
)
