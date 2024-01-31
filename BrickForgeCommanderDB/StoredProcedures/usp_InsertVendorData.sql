CREATE PROCEDURE [BFC].[usp_InsertVendorData]
    -- Parameter for VendorDetails
    @FirstName VARCHAR(25),
    @MiddleName VARCHAR(25),
    @LastName VARCHAR(25),
    @Address VARCHAR(30),
    @CityId INT,
    @PhoneNo TEXT,
    @Image NVARCHAR(MAX),
    -- Parameters for WorkerDetails
    @BatchId INT ,
    @RoleId INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        DECLARE @VendorTypeId INT
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
            [VendorTypeId]
        )
        VALUES (
            @FirstName,
            @MiddleName,
            @LastName,
            @Address,
            @CityId,
            @PhoneNo,
            @VendorTypeId
        );

        -- Get the VendorId of the inserted row
        DECLARE @VendorId INT;
        SET @VendorId = SCOPE_IDENTITY();

        -- Insert into OtherTable using the VendorId as a reference
        INSERT INTO [BFC].[WorkerDetails] (
            [VendorId],
            [BatchId] ,
            [RoleId]
        )
        VALUES (
            @VendorId,
            @BatchId ,
            @RoleId
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
