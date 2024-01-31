CREATE TABLE [BFC].[WorkerDetails]
(
    [WorkerId] INT NOT NULL IDENTITY(1,1),
	[VendorId] INT NULL, 
    [BatchId] INT NULL, 
    [RoleId] INT NULL, 
    CONSTRAINT [PK_WorkerDetails] PRIMARY KEY ([WorkerId]) 
)
