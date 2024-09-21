/*

[dbo].[GetEmployees]

*/
CREATE OR ALTER   PROCEDURE [dbo].[GetEmployees]
AS
BEGIN

	SELECT E.empid, CONCAT(E.firstname,' ', E.lastname)
		from 
		HR.Employees E
		ORDER BY E.empid asc;

END
