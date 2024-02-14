CREATE VIEW [BFC].[StockDetails] AS 
SELECT 
    SR.ReportId AS Id,
    VD.[FirstName] + ' ' + VD.[MiddleName] + ' ' + VD.[LastName] AS SupplierName,
    SR.Quantity,
    SR.PurchasePrice AS Price,
    SR.StockStatus AS [Status],
    SR.DateReported AS [Date],
    RMD.UnitPrice,
    RMD.MaterialName,
    RMD.TotalQuantity,
    RMD.Capacity
FROM 
    BFC.StockReports SR
JOIN 
    BFC.VendorDetails VD ON VD.VendorId = SR.SupplierId
JOIN 
    BFC.RawMaterialDetails RMD ON SR.MaterialId = RMD.MaterialId
