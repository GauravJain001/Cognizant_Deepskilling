SELECT * FROM(
	SELECT 
    p.ProductID,
    p.ProductName,
    p.CategoryID,
    c.CategoryName,
    p.Price,
    DENSE_RANK() OVER (PARTITION BY p.CategoryID ORDER BY p.Price DESC) AS DenseRank
    FROM Products as p JOIN Categories as c ON p.CategoryID = c.CategoryID
) 
AS TOP_THREE WHERE DenseRank <= 3;