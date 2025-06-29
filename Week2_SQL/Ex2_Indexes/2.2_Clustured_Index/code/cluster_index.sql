-- Exercise 2: Creating a Clustered Index
-- Goal: Create a clustered index on the OrderDate column in the Orders table and compare query execution time before and after index creation.

-- Step 1: Query to fetch orders before index creation
SELECT * FROM Orders WHERE OrderDate = '2023-01-15';

-- Step 2: Create a clustered index on OrderDate
CREATE CLUSTERED INDEX idx_OrderedDate ON Orders(OrderDate);


-- Step 3: Query to fetch orders after index creation
SELECT * FROM Orders WHERE OrderDate = '2023-01-15';





