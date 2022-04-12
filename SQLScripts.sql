DECLARE @RowCnt int;
DECLARE @Iterator int = 0;
DECLARE @FirstName char(256);
DECLARE @LastName char(256); 
DECLARE @results_table table(CustomerID int, FirstName char(256), LastName char(256), TotalCost float);

SELECT * FROM Customer WHERE LastName Like 'S%' ORDER By LastName DESC, FirstName DESC;

SELECT @RowCnt = COUNT(*) FROM CUSTOMER;

WHILE @Iterator < @RowCnt
BEGIN
	SELECT @FirstName = FirstName,
	@LastName = LastName FROM Customer where CustID = @Iterator;

	INSERT INTO @results_table 
	SELECT @Iterator as customer_ID, @FirstName as First_Name, @LastName as Last_Name, 
	COALESCE(SUM(cost),0) from OrderLine Where OrdID in (SELECT OrderID FROM [Order] Where CustomerID = @Iterator AND OrderDate >= DATEADD(MONTH, -6, GETDATE()))

	Set @Iterator += 1;
END

SELECT * FROM @results_table;
SELECT * FROM @results_table where TotalCost > 100 and TotalCost < 500;