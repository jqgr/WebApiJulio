/*

declare @orderdate datetime = getdate(),
	@requireddate datetime = getdate()+5,
	@shippeddate datetime = getdate()+3;

exec dbo.AddNewOrder 1, 1, 1, 'pruebashipname', 'pruebashipaddress', 'pruebashipcity', @orderdate, @requireddate, @shippeddate, 321.2123, 'pruebashipcou', 1, 987.3214, 2, 1.000

select top 1 * from [Sales].[Orders] order by 1 desc
select top 1 * from [Sales].[OrderDetails] order by 1 desc

*/
CREATE OR ALTER   PROCEDURE [dbo].[AddNewOrder]
	@custid int,
	@empid int,
	@shipperid int,
	@shipname varchar(80),
	@shipaddress varchar(120),
	@shipcity varchar(30),
	@orderdate datetime,
	@requireddate datetime,
	@shippeddate datetime,
	@freight decimal(19,4),
	@shipcountry varchar(15),
	@productid int,
	@unitprice decimal(19,4),
	@qty smallint,
	@discount numeric(4,3)

AS
BEGIN

declare @orderid int 


insert into [Sales].[Orders]
(custid, empid, orderdate, requireddate, shippeddate, shipperid, freight, shipname, shipaddress, shipcity, shipcountry)
values
(@custid, @empid, @orderdate, @requireddate, @shippeddate, @shipperid, @freight, @shipname, @shipaddress, @shipcity, @shipcountry)

select @orderid = SCOPE_IDENTITY()  

insert into [Sales].[OrderDetails]
(orderid,productid,unitprice,qty,discount)
values
(@orderid, @productid, @unitprice, @qty, @discount)

END