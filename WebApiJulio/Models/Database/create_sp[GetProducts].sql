/*

[dbo].[GetProducts]

*/
CREATE OR ALTER   PROCEDURE [dbo].[GetProducts]
AS
BEGIN

	SELECT P.productid, P.productname
		from 
		Production.Products P
		ORDER BY P.productid asc;

END
--COMMIT