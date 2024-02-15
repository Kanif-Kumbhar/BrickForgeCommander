CREATE TABLE [BFC].[ProductRawMaterialDetails]
(
    Id INT PRIMARY KEY IDENTITY(1,1),
	ProductID INT NOT NULL,
    RawMaterialID INT NOT NULL,
    MaterialQuantity DECIMAL(10, 2) NOT NULL,
)
