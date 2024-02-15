CREATE VIEW [BFC].[BrickLabourCharges] AS
SELECT 
	
	BPD.BrickId,
	(BPD.BricksMadePrice/BPD.BricksMadeAmount) AS BricksMadePrice,
	(BPD.DhulaiPrice/BPD.DhulaiPrice) AS DhulaiPrice,
	(BPD.NikashiAmount/BPD.NikashiPrice) As NikashiPrice

FROM BFC.BrickPaymentDetails BPD
