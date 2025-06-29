CREATE PROCEDURE sp_CountEmployeesInDepartment @DepartmentID INT AS BEGIN SELECT COUNT(*) AS TotalEmployees
FROM Employees WHERE DepartmentID = @DepartmentID;
END;

EXEC sp_CountEmployeesInDepartment 3;
