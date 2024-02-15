CREATE PROCEDURE BFC.InsertOrUpdateBrickPaymentDetails
    @BrickId INT,
    @BricksMadeAmount INT,
    @BricksMadePrice MONEY,
    @DhulaiAmount INT,
    @DhulaiPrice MONEY,
    @NikashiAmount INT,
    @NikashiPrice MONEY
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM BFC.BrickPaymentDetails WHERE BrickId = @BrickId)
    BEGIN       
        UPDATE BFC.BrickPaymentDetails
        SET 
            BricksMadeAmount = @BricksMadeAmount,
            BricksMadePrice = @BricksMadePrice,
            DhulaiAmount = @DhulaiAmount,
            DhulaiPrice = @DhulaiPrice,
            NikashiAmount = @NikashiAmount,
            NikashiPrice = @NikashiPrice
        WHERE BrickId = @BrickId;
    END
    ELSE
    BEGIN
        INSERT INTO BFC.BrickPaymentDetails (BrickId, BricksMadeAmount, BricksMadePrice, DhulaiAmount, DhulaiPrice, NikashiAmount, NikashiPrice)
        VALUES (@BrickId, @BricksMadeAmount, @BricksMadePrice, @DhulaiAmount, @DhulaiPrice, @NikashiAmount, @NikashiPrice);
    END
END
