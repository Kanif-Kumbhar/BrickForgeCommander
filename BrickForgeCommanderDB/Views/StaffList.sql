CREATE VIEW [BFC].[StaffList]
AS
SELECT
    WD.[WorkerId],
    WD.[VendorId] AS WorkerVendorId,
    WD.[BatchId],
    WD.[RoleId],
    RD.[RoleName],
    VD.[VendorId],
    VD.[FirstName] + ' ' + VD.[MiddleName] + ' ' + VD.[LastName] AS VendorName,
    VD.[Address] AS VendorAddress,
    VD.[CityId],
    CD.[CityName],
    VD.[PhoneNo],
    VD.[VendorTypeId],
    VT.[VendorTypeName],
    DD.[DocumentId],
    DD.[DocumentName],
    DD.[DocumentImage]
FROM
    [BFC].[WorkerDetails] WD
JOIN
    [BFC].[VendorDetails] VD ON WD.[VendorId] = VD.[VendorId]
JOIN
    [BFC].[CityDetails] CD ON VD.[CityId] = CD.[CityId]
JOIN
    [BFC].[WorkerRoleDetails] RD ON WD.[RoleId] = RD.[RoleId]
JOIN
    [BFC].[DocumentDetails] DD ON WD.[VendorId] = DD.[VendorId]
JOIN
    [BFC].[VendorTypeDetails] VT ON VD.[VendorTypeId] = VT.[VendorTypeId]

