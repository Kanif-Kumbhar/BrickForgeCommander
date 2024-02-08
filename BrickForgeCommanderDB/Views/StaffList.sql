CREATE VIEW [BFC].[StaffList] AS
SELECT 
    VD.[VendorId] AS Id,
    VD.[FirstName] + ' ' + VD.[MiddleName] + ' ' + VD.[LastName] AS VendorName,
    VD.[Address],
    CD.[CityName] AS City,
    VD.[PhoneNo],
    VBGD.BloodGroup,
    BD.[BatchName] AS Batch,
    WRD.[RoleName] AS [Role],
    DD.[DocumentName],
    DD.[DocumentImage],
    VID.[Image]
FROM 
    BFC.VendorDetails VD
JOIN 
    BFC.VendorTypeDetails VTD ON VD.VendorTypeId = VTD.VendorTypeId
JOIN 
    BFC.CityDetails CD ON VD.CityId = CD.CityId
JOIN 
    BFC.WorkerDetails WD ON VD.VendorId = WD.VendorId 
JOIN 
    BFC.BatchDetails BD ON BD.BatchId = WD.BatchId
JOIN 
    BFC.WorkerRoleDetails WRD ON WRD.RoleId = WD.RoleId
LEFT JOIN 
    BFC.DocumentDetails DD ON VD.VendorId = DD.VendorId
LEFT JOIN 
    BFC.VendorImageDetails VID ON VD.VendorId = VID.VendorId
LEFT JOIN 
    BFC.VendorBloodGroupDetails VBGD ON VD.VendorId = VBGD.VendorId
WHERE 
    VTD.[VendorTypeName] = 'Worker';
