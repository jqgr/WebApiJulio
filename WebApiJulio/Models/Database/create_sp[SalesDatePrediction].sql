/*

[dbo].[SalesDatePrediction]72

*/
CREATE OR ALTER   PROCEDURE [dbo].[SalesDatePrediction]
	@custId INT
AS
BEGIN

	declare @diasDiferencia int;

		WITH diasDiferencia AS (
		SELECT O.orderdate,
			   LEAD(O.orderdate) OVER (ORDER BY O.orderid) AS FechaSiguiente
		from 
		Sales.Customers C inner join
		Sales.Orders O on C.custid = O.custid
		where C.custid=@custId
	)
	SELECT @diasDiferencia = AVG(DATEDIFF(day, orderdate, isnull(FechaSiguiente,orderdate)))
	FROM diasDiferencia

	SELECT top 1 C.companyname, convert(varchar(50),O.orderdate, 103) orderdate, convert(varchar(50),DATEADD(day,@diasDiferencia, O.orderdate), 103) nextPredictedOrder
		from 
		Sales.Customers C inner join
		Sales.Orders O on C.custid = O.custid
		where C.custid=@custId
		order by O.orderid desc;
		
END
