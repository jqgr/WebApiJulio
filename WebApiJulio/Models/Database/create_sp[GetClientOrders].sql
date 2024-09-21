/*

[dbo].[GetClientOrders]72

*/
CREATE OR ALTER   PROCEDURE [dbo].[GetClientOrders]
	@custId INT
AS
BEGIN

	SELECT O.orderid, convert(varchar(50),O.requireddate, 103) requireddate, convert(varchar(50),O.shippeddate, 103) shippeddate, O.shipname, O.shipaddress, O.shipcity
		from 
		Sales.Orders O
		where O.custid=@custId
		order by O.orderid asc;

END