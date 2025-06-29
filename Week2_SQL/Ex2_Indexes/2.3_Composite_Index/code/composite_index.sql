-- Exercise 3: Creating a Composite Index
-- Goal: Create a composite index on the CustomerID and OrderDate columns in the Orders table and compare query execution time before and after index creation.

-- Step 1: Query to fetch orders before index creation
SELECT * FROM Orders WHERE CustomerID = 1 AND OrderDate = '2023-01-15';

-- Step 2: Create a composite index on CustomerID and OrderDate
CREATE NONCLUSTERED INDEX idx_Customer_OrderDate ON Orders (CustomerID, OrderDate);


-- Step 3: Query to fetch orders after index creation
SELECT * FROM Orders WHERE CustomerID = 1 AND OrderDate = '2023-01-15';