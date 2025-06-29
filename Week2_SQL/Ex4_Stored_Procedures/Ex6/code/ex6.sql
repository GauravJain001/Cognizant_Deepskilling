CREATE PROCEDURE sp_TotalSalaryByDepartment @DepartmentID INT,@TotalSalary DECIMAL(10,2) OUTPUT
AS BEGIN 
SELECT @TotalSalary = SUM(Salary) FROM Employees WHERE DepartmentID = @DepartmentID;
END;

DECLARE @Total DECIMAL(10,2);
EXEC sp_TotalSalaryByDepartment 2, @Total OUTPUT;
SELECT @Total AS TotalSalary;
