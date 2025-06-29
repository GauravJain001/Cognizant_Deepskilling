SELECT * FROM(
	SELECT 
    p.ProductID,
    p.ProductName,
    p.CategoryID,
    c.CategoryName,
    p.Price,
    ROW_NUMBER() OVER (PARTITION BY p.CategoryID ORDER BY p.Price DESC) AS RowNUM
    FROM Products as p JOIN Categories as c ON p.CategoryID = c.CategoryID
) 
AS TOP_THREE WHERE RowNUM <= 3;