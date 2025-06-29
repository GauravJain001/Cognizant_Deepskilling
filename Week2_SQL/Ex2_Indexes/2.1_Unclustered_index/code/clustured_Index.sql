-- Exercise 1: Creating a Non-Clustered Index
-- Goal: Create a non-clustered index on the ProductName column in the Products table and compare query execution time before and after index creation.


-- Step 1: Query to fetch product details before index creation
SELECT * FROM Products WHERE ProductName = 'Laptop';
-- Step 2: Create a non-clustered index on ProductName
CREATE NONCLUSTERED INDEX idx_ProductName ON Products(ProductName);
-- Step 3: Query to fetch product details after index creation
SELECT * FROM Products WHERE ProductName = 'Laptop';
