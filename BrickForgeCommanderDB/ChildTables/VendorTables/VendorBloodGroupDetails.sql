CREATE TABLE [BFC].[VendorBloodGroupDetails]
(
	[VendorId] INT NOT NULL, 
    [BloodGroup] VARCHAR(25) NOT NULL, 
    CONSTRAINT [FK_VendorBloodGroupDetails_BloodGroup] FOREIGN KEY ([VendorId]) REFERENCES [BFC].[VendorDetails]([VendorId]) 
)
