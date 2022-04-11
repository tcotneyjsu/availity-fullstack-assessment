/*INSERT INTO [Order] (OrderID, CustomerID, OrderDate) VALUES (5, 6, '2021-04-12');*/
/*INSERT INTO Customer (CustID, FirstName, LastName) VALUES (0, 'James', 'Gordon');*/
/*INSERT INTO OrderLine (OrderLineID, OrdID, ItemName, Cost, Quantity) VALUES (1, 0, 'Headphones', 80.39, 1);*/


DECLARE @RowCnt int;
DECLARE @Iterator int = 0;
DECLARE @FirstName char(256);
DECLARE @LastName char(256);

SELECT * FROM [Customer];
SELECT * FROM [Order];
SELECT * FROM [OrderLine];

SELECT * FROM Customer WHERE LastName Like 'S%' ORDER By LastName DESC, FirstName DESC;

SELECT @RowCnt = COUNT(*) FROM CUSTOMER;
PRINT @RowCnt;

WHILE @Iterator < @RowCnt
BEGIN
	SELECT @FirstName = FirstName,
	@LastName = LastName FROM Customer where CustID = @Iterator;

	SELECT @Iterator as customer_ID, @FirstName as First_Name, @LastName as Last_Name, COALESCE(SUM(cost),0) as total_cost from OrderLine Where exists (SELECT * FROM [Order] Where CustomerID = @Iterator AND OrderDate >= DATEADD(MONTH, -6, GETDATE()))

	Set @Iterator += 1;
END

SELECT * FROM [Customer];