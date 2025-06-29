SELECT c.Region, cat.CategoryName,SUM(od.Quantity) AS Total_Quantity from OrderDetails od 
JOIN Orders o ON od.OrderID = o.OrderID
JOIN Customers  c ON c.CustomerID = o.CustomerID
JOIN Products p ON od.ProductID = p.ProductID
JOIN Categories cat ON p.CategoryID = cat.CategoryID
GROUP BY GROUPING SETS(
(cat.CategoryName,c.Region),
(c.Region),
(cat.CategoryName)
);
