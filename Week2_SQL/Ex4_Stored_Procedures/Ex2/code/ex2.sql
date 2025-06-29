ALTER PROCEDURE sp_GetEmployeesByDepartment @DepartmentID INT AS BEGIN SELECT FirstName, LastName, Salary, 
JoinDate FROM Employees WHERE DepartmentID = @DepartmentID;
END;
