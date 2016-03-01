USE [master]
If Exists (Select Name from SysDatabases Where Name = 'EntityFrameworkDemos')
  Begin
   ALTER DATABASE [EntityFrameworkDemos] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
   DROP DATABASE [EntityFrameworkDemos]
  End
Go
Create Database EntityFrameworkDemos;
Go
USE EntityFrameworkDemos;
Go

--( Make the Tables )--
Create Table Customers 
  ( CustomerID int, CustomerName nVarchar(100), Primary Key(CustomerID) );
Go
Create Table Products 
  ( ProductID int, ProductName nVarchar(100), ProductPrice decimal(18,2), Primary Key(ProductID) );
Go
Create Table Orders
  ( OrderID int, CustomerId int References Customers(CustomerID), OrderDate datetime, Primary Key(OrderID) );
Go
Create Table OrderLineItems
  ( OrderID int References Orders(OrderID), OrderLineItemID int, ProductID int References Products(ProductID), OrderQty int, OrderSalesPrice decimal(18,2), Primary Key(OrderID, ProductID) );
Go

--( Add Some Data )--
Insert Into Customers (CustomerID, CustomerName)
  Values (1, 'Bob Smith'), (2, 'Sue Jones');
Go
Insert Into Products (ProductID, ProductName, ProductPrice)
  Values (100, 'Prod A', 9.99), (200, 'Prod B', 39.99);
Go
Insert Into Orders (OrderID, CustomerId, OrderDate)
  Values (1, 1, '2010-01-01'), (2, 2, '2010-01-01' ), (3, 1, '2010-01-02');
Go
Insert Into OrderLineItems (OrderID, OrderLineItemID, ProductID, OrderQty, OrderSalesPrice)
  Values (1, 1, 100, 3, 9.99), (1, 2, 200, 1, 39.99), (2, 1, 100, 1, 9.99);
Go

/*
--( Review the current data )--
Select CustomerID, CustomerName From [dbo].[Customers];
Select OrderID, CustomerId, OrderDate From [dbo].[Orders];
Select OrderID, OrderLineItemID, ProductID, OrderQty, OrderSalesPrice From [dbo].[OrderLineItems];
Select ProductID, ProductName, ProductPrice From [dbo].[Products];
*/

--( Create Database Abstraction Layer Objects: Views)---
Go
Create View vCustomers AS Select CustomerID, CustomerName From [dbo].[Customers];
Go
Create View vOrders AS Select OrderID, CustomerId, OrderDate From [dbo].[Orders];
Go
Create View vOrderLineItems AS Select OrderID, OrderLineItemID, ProductID, OrderQty, OrderSalesPrice From [dbo].[OrderLineItems];
Go
Create View vProducts AS Select ProductID, ProductName, ProductPrice From [dbo].[Products];
Go
Create View vRptOrdersByProducts 
  AS
  Select Products.ProductName, Orders.OrderId, Customers.CustomerName, Orders.OrderDate, OrderLineItems.OrderQty, OrderLineItems.OrderSalesPrice 
  From Products 
  Join OrderLineItems ON Products.ProductID = OrderLineItems.ProductID
  Join Orders ON OrderLineItems.OrderID = Orders.OrderID
  Join Customers ON Orders.CustomerID = Customers.CustomerID;
Go
/*
--( Review the current data through the Views )--
Select CustomerID, CustomerName From vCustomers;
Select OrderID, CustomerId, OrderDate From vOrders;
Select OrderID, OrderLineItemID, ProductID, OrderQty, OrderSalesPrice From vOrderLineItems;
Select ProductID, ProductName, ProductPrice From vProducts;
Select ProductName, OrderId, CustomerName, OrderDate, OrderQty, OrderSalesPrice From vRptOrdersByProducts;
*/


--( Create Database Abstraction Layer Objects: Stored Procedures )---
-- For the Customers Table --
Create Procedure pInsCustomer( @CustomerID int, @CustomerName nVarchar(100) )
  AS 
  BEGIN 
    Declare @ReturnCode int
	--( add validation code here )--
    Begin Try
	  Insert Into Customers (CustomerID, CustomerName)
        Values (@CustomerID, @CustomerName)
	Set @ReturnCode = 100 -- success code
	End Try
	Begin Catch
	--( add error handling code here )--
	Set @ReturnCode = -100 -- fail code
	End Catch
	Return @ReturnCode
  END;
Go
Create Procedure pUpdateCustomer( @CustomerID int, @CustomerName nVarchar(100) )
  AS 
  BEGIN 
    Declare @ReturnCode int
	--( add validation code here )--
    Begin Try
	  Update Customer
	    Set CustomerName = @CustomerName
		Where CustomerId = @CustomerID
	Set @ReturnCode = 100 -- success code
	End Try
	Begin Catch
	--( add error handling code here )--
	Set @ReturnCode = -100 -- fail code
	End Catch
	Return @ReturnCode
  END;
Go

Create Procedure pDelCustomer( @CustomerID int )
  AS 
  BEGIN 
    Declare @ReturnCode int
	--( add validation code here )--
    Begin Try
	  Delete From Customer
	  Where CustomerID = @CustomerID
	Set @ReturnCode = 100 -- success code
	End Try
	Begin Catch
	--( add error handling code here )--
	Set @ReturnCode = -100 -- fail code
	End Catch
	Return @ReturnCode
  END;

/* Template to add more...
Create Procedure 
  AS 
  BEGIN 
    Declare @ReturnCode int
	--( add validation code here )--
    Begin Try

	Set @ReturnCode = 100 -- success code
	End Try
	Begin Catch
	--( add error handling code here )--
	Set @ReturnCode = -100 -- fail code
	End Catch
	Return @ReturnCode
  END;
*/

