CREATE FUNCTION fn_GetEmployeesByDepartment
(
    @DeptID INT
)
RETURNS TABLE
AS
RETURN
(
    SELECT EmployeeID, FirstName, LastName, Salary, JoinDate
    FROM Employees
    WHERE DepartmentID = @DeptID
);

SELECT * FROM dbo.fn_GetEmployeesByDepartment(3); 
