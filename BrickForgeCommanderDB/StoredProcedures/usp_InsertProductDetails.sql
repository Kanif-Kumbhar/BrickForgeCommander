CREATE PROCEDURE [BFC].[usp_InsertProductDetails]
(
    @BrickId INT,
    @UnitPrice DECIMAL(12, 2),
    @ProfitMargin DECIMAL(12, 2),
    @TotalAmount MONEY,
    @ScoreId INT
)
AS
BEGIN
    DECLARE @ProductId INT

    INSERT INTO [BFC].[ProductDetails] ([BrickId], [UnitPrice], [ProfitMargin], [TotalAmount], [ScoreId])
    VALUES (@BrickId, @UnitPrice, @ProfitMargin, @TotalAmount, @ScoreId)

END