CREATE PROCEDURE sp_GetEmployeesByDepartment @DepartmentID INT AS
BEGIN SELECT FirstName, LastName, JoinDate FROM Employees WHERE DepartmentID = @DepartmentID;
END;



EXEC sp_GetEmployeesByDepartment 2;
