
Use TempDB
Drop Table RandalsData

Create Table RandalsData
( Id int Primary Key, ObjectName varchar(20))

Select Id, ObjectName 
from RandalsData
Where Id = 1

Insert Into RandalsData(Id, ObjectName)
Values(1, 'PlayersCat')

Update RandalsData 
Set ObjectName = 'Dog1'
Where Id = 1

Delete From RandalsData
Where Id = 1

Use Northwind
Create Proc AddStuff
AS
 Declare @Answer int
 Set @Answer = 5 + 5
 Return @Answer

--------------------------
Exec AddStuff



