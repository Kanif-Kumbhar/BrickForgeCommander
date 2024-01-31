CREATE TABLE [BFC].[AttendanceDetails]
(
    [AttendenceId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [VendorId] INT NOT NULL,
    [AttendanceDate] DATETIME2 NOT NULL, 
    [CheckInTime] DATETIME2 NOT NULL,
    [CheckOutTime] DATETIME2 NULL
);
