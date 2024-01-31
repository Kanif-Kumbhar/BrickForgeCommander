CREATE PROCEDURE [BFC].[usp_InsertVendorData]
    -- Parameter for VendorDetails
    @FirstName VARCHAR(25),
    @MiddleName VARCHAR(25),
    @LastName VARCHAR(25),
    @Address VARCHAR(30),
    @CityId INT,
    @PhoneNo TEXT,
    @VendorTypeId INT OUTPUT,
    @Image IMAGE,
    @UserId INT,
    -- Parameters for WorkerDetails
    @BatchId VARCHAR(50)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Set @VendorTypeId based on VendorTypeName
        SET @VendorTypeId = (SELECT VendorTypeId FROM BFC.VendorTypeDetails WHERE VendorTypeName = 'Worker');

        -- Insert into VendorDetails table
        INSERT INTO [BFC].[VendorDetails] (
            [FirstName],
            [MiddleName],
            [LastName],
            [Address],
            [CityId],
            [PhoneNo],
            [VendorTypeId],
            [UserId]
        )
        VALUES (
            @FirstName,
            @MiddleName,
            @LastName,
            @Address,
            @CityId,
            @PhoneNo,
            @VendorTypeId,
            @UserId
        );

        -- Get the VendorId of the inserted row
        DECLARE @VendorId INT;
        SET @VendorId = SCOPE_IDENTITY();

        -- Insert into OtherTable using the VendorId as a reference
        INSERT INTO [BFC].[WorkerDetails] (
            [VendorId],
            [BatchId]
        )
        VALUES (
            @VendorId,
            @BatchId
        );

        -- Increase BatchSize in BatchDetails
        UPDATE [BFC].[BatchDetails]
        SET [BatchSize] = [BatchSize] + 1
        WHERE [BatchId] = @BatchId;

        INSERT INTO [BFC].[VendorImageDetails] (
            [VendorId],
            [Image]
        )
        VALUES (
            @VendorId,
            @Image
        );    
        COMMIT;
    END TRY
    BEGIN CATCH
        ROLLBACK;
    END CATCH;
END;
