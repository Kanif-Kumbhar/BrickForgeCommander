CREATE PROCEDURE [BFC].[usp_InsertProductRawMaterials]
(
    @RawMaterialID INT,
    @MaterialQuantity DECIMAL(10, 2)
)
AS
BEGIN
    DECLARE @ProductId INT

    SET @ProductId = IDENT_CURRENT('BFC.ProductDetails')

    INSERT INTO [BFC].[ProductRawMaterialDetails] (ProductID, RawMaterialID, MaterialQuantity)
    VALUES (@ProductId, @RawMaterialID, @MaterialQuantity)
END