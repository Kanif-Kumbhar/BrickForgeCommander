CREATE TABLE [BFC].[VendorDetails]
(
	[VendorId] INT NOT NULL PRIMARY KEY Identity(1,1), 
    [FirstName] VARCHAR(25) NOT NULL, 
    [MiddleName] VARCHAR(25) NOT NULL,
    [LastName] VARCHAR(25) NOT NULL, 
    [Address] VARCHAR(30) NOT NULL, 
    [CityId] INT NOT NULL,
    [PhoneNo] TEXT NOT NULL, 
    [VendorTypeId] INT NOT NULL, 
    [UserId] INT NULL, 
    CONSTRAINT [FK_VendorDetails_VendorType] FOREIGN KEY ([VendorTypeId]) REFERENCES [BFC].[VendorTypeDetails]([VendorTypeId]), 
    CONSTRAINT [FK_VendorDetails_City] FOREIGN KEY ([CityId]) REFERENCES [BFC].[CityDetails]([CityId]), 
)
