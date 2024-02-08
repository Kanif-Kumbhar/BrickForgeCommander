CREATE PROCEDURE [BFC].[usp_InsertRawMaterialDetails]
(
    @MaterialName VARCHAR(25),
    @Capacity INT,
    @VendorId INT
)
AS 
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;

    DECLARE @MaterialId INT;
    DECLARE @StockStatus VARCHAR(25);

    INSERT INTO BFC.RawMaterialDetails (MaterialName, Capacity, SupplierId)
    VALUES (@MaterialName, @Capacity, @VendorId);

    SET @MaterialId = SCOPE_IDENTITY();

    IF NOT EXISTS (SELECT 1 FROM BFC.VendorDetails WHERE VendorId = @VendorId)
    BEGIN
        PRINT 'Error: SupplierId does not exist.';
        ROLLBACK TRANSACTION;
        RETURN;
    END;

    COMMIT TRANSACTION;
END;
