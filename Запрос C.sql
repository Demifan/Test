USE Test

SELECT NumberContract
FROM QuantitativeComposition
RIGHT JOIN LightCars ON QuantitativeComposition.Id = LightCars.ContractId
WHERE TypeTransmission = 'mechanical' AND DatePurchase > '2010-01-01'