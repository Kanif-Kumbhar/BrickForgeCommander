CREATE PROCEDURE [BFC].[usp_InsertStockDetails]
(
    @MaterialId INT,
    @PurchasePrice MONEY,
    @Quantity INT
)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    DECLARE @Capacity INT;
    DECLARE @StockStatus VARCHAR(25);
    DECLARE @NewUnitPrice MONEY;
    DECLARE @PreviousTotalPurchase MONEY;
    DECLARE @PreviousQuantity INT;
    DECLARE @PreviousUnitPrice MONEY;

    SELECT 
        @PreviousTotalPurchase = SUM(Quantity * UnitPrice),
        @PreviousQuantity = SUM(Quantity)
    FROM 
        BFC.StockReports
    WHERE 
        MaterialId = @MaterialId;

    IF @PreviousQuantity > 0
    BEGIN
        SET @PreviousUnitPrice = @PreviousTotalPurchase / @PreviousQuantity;
    END
    ELSE
    BEGIN
        SET @PreviousUnitPrice = @PurchasePrice;
    END;

    IF @PreviousQuantity > 0
    BEGIN
        SET @NewUnitPrice = ((@PreviousUnitPrice * @PreviousQuantity) + @PurchasePrice) / (@PreviousQuantity + @Quantity);
    END
    ELSE
    BEGIN
        SET @NewUnitPrice = @PurchasePrice / @Quantity; -- Use PurchasePrice directly if PreviousQuantity is 0
    END;

    SELECT @Capacity = Capacity FROM BFC.RawMaterialDetails WHERE MaterialId = @MaterialId;

    IF @Quantity > @Capacity
    BEGIN
        SET @StockStatus = 'Overstocked';
    END
    ELSE IF @Quantity < @Capacity
    BEGIN
        SET @StockStatus = 'Understocked';
    END
    ELSE
    BEGIN
        SET @StockStatus = 'Fullstocked';
    END;

    INSERT INTO BFC.StockReports (MaterialId, Quantity, StockStatus, PurchasePrice,DateReported)
    VALUES (@MaterialId, @Quantity, @StockStatus, @PurchasePrice,GETDATE());

    UPDATE BFC.StockReports SET UnitPrice = @NewUnitPrice WHERE MaterialId = @MaterialId;

    COMMIT TRANSACTION;
END;
