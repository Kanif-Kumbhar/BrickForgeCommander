CREATE TABLE [BFC].[BrickPaymentDetails]
(
    Id INT PRIMARY KEY IDENTITY(1,1),
	BrickId INT,
    BricksMadeAmount INT,
    BricksMadePrice MONEY,
    DhulaiAmount INT,
    DhulaiPrice MONEY,
    NikashiAmount INT,
    NikashiPrice MONEY, 
    CONSTRAINT [FK_BrickPaymentDetails_BrickDetails] FOREIGN KEY ([BrickId]) REFERENCES BFC.BrickDetails(BrickId),
)
