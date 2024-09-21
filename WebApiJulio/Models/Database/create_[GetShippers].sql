/*

[dbo].[GetShippers]

*/
CREATE OR ALTER   PROCEDURE [dbo].[GetShippers]
AS
BEGIN

	SELECT S.shipperid, S.companyname
		from 
		Sales.Shippers S
		ORDER BY S.shipperid asc;

END
