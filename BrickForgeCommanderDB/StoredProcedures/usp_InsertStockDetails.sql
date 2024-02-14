CREATE PROCEDURE [BFC].[usp_InsertStockDetails]
(
    @MaterialId INT,
    @VendorId INT,
    @PurchasePrice MONEY,
    @Quantity INT
)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    DECLARE @Capacity INT;
    DECLARE @TotalStockAvailable INT;
    DECLARE @StockStatus VARCHAR(25);
    DECLARE @NewUnitPrice MONEY;
    DECLARE @TotalPurchase MONEY;
    DECLARE @TotalQuantity INT;
    DECLARE @PreviousUnitPrice MONEY;

    SELECT @TotalPurchase = SUM(PurchasePrice),
           @TotalQuantity = SUM(Quantity)
    FROM BFC.StockReports
    WHERE MaterialId = @MaterialId;
            
    SET @StockStatus = 'Understocked';

    IF @TotalQuantity > 0
        SET @NewUnitPrice = @TotalPurchase / @TotalQuantity;
    ELSE
        SET @NewUnitPrice = @PurchasePrice / @Quantity;

    INSERT INTO BFC.StockReports (MaterialId, SupplierId, Quantity, StockStatus, PurchasePrice, DateReported)
    VALUES (@MaterialId, @VendorId, @Quantity, @StockStatus, @PurchasePrice, GETDATE());

    UPDATE BFC.RawMaterialDetails SET TotalQuantity = TotalQuantity + @Quantity, UnitPrice = @NewUnitPrice WHERE MaterialId = @MaterialId;

    SELECT @Capacity = Capacity, @TotalStockAvailable = TotalQuantity FROM BFC.RawMaterialDetails WHERE MaterialId = @MaterialId;

    IF @TotalStockAvailable > @Capacity
        SET @StockStatus = 'Overstocked';
    ELSE IF @TotalStockAvailable < @Capacity 
        SET @StockStatus = 'Understocked';
    ELSE IF @TotalStockAvailable = @Capacity
        SET @StockStatus = 'Fully Stocked';
    
    UPDATE BFC.StockReports SET StockStatus = @StockStatus WHERE MaterialId = @MaterialId;
    COMMIT TRANSACTION;
END;
