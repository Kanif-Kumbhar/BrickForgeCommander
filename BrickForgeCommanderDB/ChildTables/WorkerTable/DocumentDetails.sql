CREATE TABLE [BFC].[DocumentDetails]
(
    [DocumentId] INT NOT NULL IDENTITY(1,1),
    [VendorId] INT NOT NULL,
    [DocumentName] VARCHAR(50) NOT NULL,
    [DocumentImage] NVARCHAR(MAX) NULL,
    CONSTRAINT [PK_DocumentDetails] PRIMARY KEY ([DocumentId]),
    CONSTRAINT [FK_DocumentDetails_Vendor] FOREIGN KEY ([VendorId]) REFERENCES [BFC].[VendorDetails]([VendorId])
);
