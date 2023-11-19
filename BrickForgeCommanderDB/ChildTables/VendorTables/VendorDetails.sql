CREATE TABLE [kanif].[VendorDetails]
(
	[VendorId] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(15) NOT NULL, 
    [LastName] VARCHAR(15) NOT NULL, 
    [CityId] INT NOT NULL, 
    [VillageId] INT NOT NULL, 
    [PhoneNo] TEXT NOT NULL
)
