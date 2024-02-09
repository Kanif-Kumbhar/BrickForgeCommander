CREATE PROCEDURE [BFC].[usp_InsertRawMaterialDetails]
(
    @MaterialName VARCHAR(25),
    @Capacity INT
)
AS 
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;

    DECLARE @MaterialId INT;
    DECLARE @StockStatus VARCHAR(25);

    INSERT INTO BFC.RawMaterialDetails (MaterialName, Capacity)
    VALUES (@MaterialName, @Capacity);

    SET @MaterialId = SCOPE_IDENTITY();

    COMMIT TRANSACTION;
END;
