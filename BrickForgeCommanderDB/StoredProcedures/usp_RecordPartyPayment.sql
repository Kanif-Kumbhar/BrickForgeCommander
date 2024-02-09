CREATE PROCEDURE [BFC].[usp_RecordPartyPayment]
(
    @PaymentType VARCHAR(25),
    @TotalAmount MONEY,
    @AmountPaid MONEY,
    @RemainingAmount MONEY,
    @VendorId INT
)
AS 
BEGIN
    SET NOCOUNT ON;

    BEGIN TRANSACTION;

    INSERT INTO [BFC].[PartyPaymentDetails] (PaymentType, TotalAmount, AmountPaid, RemainingAmount, PaymentDate, VendorId)
    VALUES (@PaymentType, @TotalAmount, @AmountPaid, @RemainingAmount, GETDATE(), @VendorId);

    COMMIT TRANSACTION;

END;
