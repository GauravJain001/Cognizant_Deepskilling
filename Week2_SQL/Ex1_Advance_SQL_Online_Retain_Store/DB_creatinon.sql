-- Categories Table
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY,
    CategoryName VARCHAR(50)
);

-- Products Table
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    CategoryID INT,
    Price DECIMAL(10,2),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- Customers Table
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    Region VARCHAR(50)
);

-- Orders Table
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

-- OrderDetails Table
CREATE TABLE OrderDetails (
    OrderDetailID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    UnitPrice DECIMAL(10,2),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

-- StagingProducts Table (for MERGE exercise)
CREATE TABLE StagingProducts (
    ProductID INT PRIMARY KEY,
    UpdatedPrice DECIMAL(10,2)
);

INSERT INTO Categories VALUES
(1, 'Electronics'),
(2, 'Appliances'),
(3, 'Cameras');


INSERT INTO Products VALUES
(1, 'Laptop',        1, 800.00),
(2, 'Smartphone',    1, 500.00),
(3, 'Tablet',        1, 300.00),
(4, 'TV',            2, 1200.00),
(5, 'Washing Machine',2, 1000.00),
(6, 'Camera',        3, 600.00),
(7, 'DSLR',          3, 1500.00);


INSERT INTO Customers VALUES
(101, 'John Doe',    'North'),
(102, 'Jane Smith',  'South'),
(103, 'Michael Lee', 'West'),
(104, 'Sara Khan',   'East'),
(105, 'David Wang',  'North');


INSERT INTO Orders VALUES
(201, 101, '2025-06-01'),
(202, 102, '2025-06-02'),
(203, 103, '2025-06-03'),
(204, 104, '2025-06-04'),
(205, 101, '2025-06-05'),
(206, 101, '2025-06-06'),
(207, 101, '2025-06-07'),
(208, 105, '2025-06-08');


INSERT INTO OrderDetails VALUES
(301, 201, 1, 1, 800.00),   -- Laptop
(302, 201, 3, 2, 300.00),   -- Tablet
(303, 202, 2, 1, 500.00),   -- Smartphone
(304, 203, 4, 1, 1200.00),  -- TV
(305, 204, 5, 1, 1000.00),  -- Washing Machine
(306, 205, 6, 2, 600.00),   -- Camera
(307, 206, 7, 1, 1500.00),  -- DSLR
(308, 207, 1, 1, 800.00),   -- Laptop
(309, 208, 2, 1, 500.00);   -- Smartphone


INSERT INTO StagingProducts VALUES
(1, 750.00),   -- Laptop price updated
(3, 320.00),   -- Tablet price updated
(8, 650.00);   -- New Product (not in Products yet)
