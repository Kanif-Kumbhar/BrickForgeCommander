CREATE TABLE [BFC].[WorkerDetails]
(
    [WorkerId] INT NOT NULL IDENTITY(1,1),
	[VendorId] INT NOT NULL, 
    [BatchId] INT NULL, 
    [RoleId] INT NULL, 
    CONSTRAINT [PK_WorkerDetails] PRIMARY KEY ([WorkerId]), 
    CONSTRAINT [FK_WorkerDetails_Vendor] FOREIGN KEY ([VendorId]) REFERENCES [BFC].[VendorDetails]([VendorId]), 
    CONSTRAINT [FK_WorkerDetails_Batch] FOREIGN KEY ([BatchId]) REFERENCES [BFC].[BatchDetails]([BatchId]), 
    CONSTRAINT [FK_WorkerDetails_Role] FOREIGN KEY ([RoleId]) REFERENCES [BFC].[WorkerRoleDetails]([RoleId]), 
)

