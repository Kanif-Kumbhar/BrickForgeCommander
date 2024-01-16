CREATE TABLE [BFC].[Orders]
(
	[OrderId] INT NOT NULL PRIMARY KEY, 
    [OrderDate] DATETIME NOT NULL, 
    [OrderNumber] NVARCHAR(10) NOT NULL, 
    [VendorId] INT NOT NULL, 
    [StatusId] INT NOT NULL, 
    [TotalAmount] DECIMAL(12, 2) NOT NULL
)
