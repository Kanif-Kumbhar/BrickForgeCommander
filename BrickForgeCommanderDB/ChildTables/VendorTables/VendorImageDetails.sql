CREATE TABLE [BFC].[VendorImageDetails]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [VendorId] INT NOT NULL FOREIGN KEY REFERENCES [BFC].[VendorDetails]([VendorId]), 
    [Image] NVARCHAR(MAX) NULL
);

