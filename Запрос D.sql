USE Test

SELECT *
FROM
(SELECT DATEPART(q, DatePurchase) AS Quarter, COUNT(DatePurchase) AS CountSales, 'Light' AS Type
FROM QuantitativeComposition
JOIN LightCars ON QuantitativeComposition.Id = LightCars.ContractId
GROUP BY DATEPART(q, DatePurchase)
UNION
SELECT DATEPART(q, DatePurchase) AS Quarter, COUNT(DatePurchase) AS CountSales, 'Heavy' AS Type
FROM QuantitativeComposition
JOIN HeavyCars ON QuantitativeComposition.Id = HeavyCars.ContractId
GROUP BY DATEPART(q, DatePurchase)) AS Q
ORDER BY Type DESC