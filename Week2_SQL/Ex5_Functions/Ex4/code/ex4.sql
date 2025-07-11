ALTER FUNCTION fn_CalculateBonus
(
    @Salary DECIMAL(10,2)
)
RETURNS DECIMAL(10,2)
AS
BEGIN
    RETURN @Salary * 0.15;
END;

SELECT FirstName, Salary, dbo.fn_CalculateBonus(Salary) AS NewBonus FROM Employees;
