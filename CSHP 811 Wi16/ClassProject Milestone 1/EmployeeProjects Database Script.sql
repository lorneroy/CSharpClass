Set NoCount On -- Turns off the annoying "One Row affected" messages 
-- Note: Do not place the Set NoCount On option inside a Stored Procedure, since it 
-- will send a false error to an ADO.NET DataAdpater object.

-- 1) Make the databse
USE [master]
GO
If Exists(Select Name from master.Sys.databases where name = 'EmployeeProjects')
 Begin 
  ALTER DATABASE [EmployeeProjects] SET SINGLE_USER WITH ROLLBACK IMMEDIATE 
	Drop Database[EmployeeProjects]
 End 
GO
 
CREATE DATABASE [EmployeeProjects]
GO

USE [EmployeeProjects]
GO

-- 2) Make the tables
CREATE TABLE [dbo].[Employees]
(
	[EmployeeId] [int] NOT NULL PRIMARY KEY ,
	[EmployeeName] [varchar](100) NOT NULL,
)
GO

CREATE TABLE [dbo].[Projects]
(
	[ProjectId] [int] NOT NULL PRIMARY KEY,
	[ProjectName] [varchar](100) NOT NULL,
	[ProjectDescription] [varchar](5000) NOT NULL,
)
GO

CREATE TABLE [dbo].[EmployeeProjectHours]
(
	[EmployeeId] [int] NOT NULL,
	[ProjectId] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Hours] [decimal](18, 2) NOT NULL,
	CONSTRAINT [PK_EmployeeProjectHours] PRIMARY KEY CLUSTERED 
		([EmployeeId] ASC,[ProjectId] ASC,[Date] ASC)
)
GO

CREATE TABLE [dbo].[ThisYearsDates]
(
	[DateId] [int] Identity NOT NULL PRIMARY KEY,
	[DateName] [varchar](100) NOT NULL,
)
GO

CREATE TABLE [dbo].[ValidHourEntries]
(
	[TimePeriodId] [int] Identity NOT NULL PRIMARY KEY,
	[TimePeriod] [varchar](100) NOT NULL,
)
GO

-- 3) Fill the tables with test data
-- Add two test employees
Insert into [dbo].[Employees] Values (1, 'Bob Smith')
Insert into [dbo].[Employees] Values (2, 'Sue Jones')
GO
-- Add two test Projects
Insert into [dbo].[Projects] Values (100, 'Accounting DB Upgrade', 'Upgrade the Accounting Database to our new SQL 2008 Server')
Insert into [dbo].[Projects] Values (101, 'Accounting Application Upgrade', 'Modify our existing Accounting Application to connect to the new upgraded server')
GO
-- Add four test Employee Project Hours
Insert into [dbo].[EmployeeProjectHours] Values (1,100,'1/1/' + Cast(Year(Getdate()) as varchar(4)), 6)
Insert into [dbo].[EmployeeProjectHours] Values (1,100,'1/2/' + Cast(Year(Getdate()) as varchar(4)), 4)
Insert into [dbo].[EmployeeProjectHours] Values (2,101,'1/1/' + Cast(Year(Getdate()) as varchar(4)), 5.5)
Insert into [dbo].[EmployeeProjectHours] Values (2,101,'1/2/' + Cast(Year(Getdate()) as varchar(4)), 6)
GO

-- Add This years dates
Declare @DateId int = 1
Declare @Date datetime = '1/1/' + Cast(Year(GetDate()) as Varchar(4));
While (Year(@Date) < (Year(GetDate()) + 1))
	Begin
		Insert into [dbo].[ThisYearsDates]Values(Convert(varchar(50), @Date, 101) )
		Set @DateId = @DateId + 1
		Set @Date = DateAdd(dd, 1, @Date)
	End
GO

-- Add Valid Hourly Entries
Declare @TimePeriod decimal(18,2) = 0
While ( @TimePeriod <= 24)
	Begin 
		Insert into [ValidHourEntries]( TimePeriod) Values (@TimePeriod)
		Set @TimePeriod = @TimePeriod + .25 
	End
Go

-- 4) Review everything you have so far
Select * From [dbo].[Employees]
Select * From [dbo].[Projects]
Select * From [dbo].[EmployeeProjectHours]
Select * From [dbo].[ThisYearsDates]
Select * From [dbo].[ValidHourEntries]
GO


-- 5) Create Select Sprocs for Tables
Create Proc pSelEmployeeNames
  AS
  Begin
    Declare @RC int = 0
    Begin Try
  		Select 
  			EmployeeName 
		From [dbo].[Employees]
		Set @RC = 100 -- Indicates Success	
    End Try
    Begin Catch
		Set @RC = -100 --Indicates Error
    End Catch	
    Return @RC
  End	
GO

Create Proc pSelProjectNames
  AS
  Begin
    Declare @RC int = 0
    Begin Try
		Select 
			ProjectName 
		From [dbo].[Projects]
		Set @RC = 100 -- Indicates Success			
    End Try
    Begin Catch
		Set @RC = -100 --Indicates Error
    End Catch	
    Return @RC
  End	
GO

Create Proc pSelEmployeeProjectHours
  AS
  Begin
    Declare @RC int = 0
    Begin Try  
		SELECT 
			dbo.EmployeeProjectHours.Date, 
			dbo.Employees.EmployeeName, 
			dbo.Projects.ProjectName, 
			dbo.EmployeeProjectHours.Hours
        FROM  dbo.EmployeeProjectHours 
		INNER JOIN dbo.Employees 
			ON dbo.EmployeeProjectHours.EmployeeId = dbo.Employees.EmployeeId 
        INNER JOIN dbo.Projects 
			ON dbo.EmployeeProjectHours.ProjectId = dbo.Projects.ProjectId
	Set @RC = 100 -- Indicates Success			
    End Try
    Begin Catch
		Set @RC = -100 --Indicates Error
    End Catch	
    Return @RC
  End		
GO

Create Proc pSelThisYearsDates
  AS
  Begin
    Declare @RC int = 0
    Begin Try
	  SELECT 
	   [DateId]
      ,[DateName] 
	  FROM [ThisYearsDates]
		Set @RC = 100 -- Indicates Success			
    End Try
    Begin Catch
		Set @RC = -100 --Indicates Error
    End Catch	
    Return @RC
  End	
GO


Create Proc pSelValidHours
  AS
  Begin
    Declare @RC int = 0
    Begin Try
		Select
		TimePeriodId,
		TimePeriod
		From ValidHourEntries
		Set @RC = 100 -- Indicates Success			
    End Try
    Begin Catch
		Set @RC = -100 --Indicates Error
    End Catch	
    Return @RC
  End	
GO


	-- 5a) Review everything you have so far
Exec pSelEmployeeNames
Exec pSelProjectNames
Exec pSelEmployeeProjectHours
Exec pSelThisYearsDates
Exec pSelValidHours
GO
		
		
-- 6) Insert Sprocs
Create Proc pInsEmployeeNames
( @EmployeeId int, @EmployeeName varchar(100))
  AS
  Begin
    Declare @RC int = 0
    Begin Try  
	  Begin Transaction  
		Insert into [dbo].[Employees] Values (@EmployeeId,@EmployeeName)
	  Commit Transaction
	Set @RC = 100 -- Indicates Success			
    End Try
    Begin Catch
		Set @RC = -100 --Indicates Error
		Rollback Transaction			
    End Catch	
    Return @RC
  End	
GO

Create Proc pInsProjectNames
( @ProjectId int, @ProjectName varchar(100), @ProjectDescription varchar(5000))
  AS
  Begin
    Declare @RC int = 0
    Begin Try  
	  Begin Transaction    
		Insert into [dbo].[Projects] Values (@ProjectId, @ProjectName, @ProjectDescription)
	  Commit Transaction
	Set @RC = 100 -- Indicates Success			
    End Try
    Begin Catch
		Set @RC = -100 --Indicates Error
		Rollback Transaction			
    End Catch	
    Return @RC
  End	
GO

Create Proc pInsEmployeeProjectHours
( @EmployeeName varchar(100), @ProjectName varchar(100), @Date datetime, @Hours decimal(18,2))
  AS
  Begin
    Declare @RC int = 0, @EmployeeId Int = 0, @ProjectId int = 0    
    Begin Try  
		-- Look up the IDs

		Select @EmployeeId = EmployeeId From dbo.Employees Where EmployeeName = @EmployeeName
		Select @ProjectId = ProjectId From dbo.Projects Where ProjectName = @ProjectName	
	  Begin Transaction  		
	 	Insert into [dbo].[EmployeeProjectHours] Values(@EmployeeId, @ProjectId, @Date, @Hours) 
	  Commit Transaction		
    End Try
    Begin Catch
		Set @RC = -100 --Indicates Error
		Rollback Transaction		
    End Catch	
    Return @RC
  End	
GO

	-- 6a) Review everything you have so far
Exec pInsEmployeeNames @EmployeeId = 3 , @EmployeeName = 'Test User' 
Exec pInsProjectNames @ProjectId = 103, @ProjectName = 'Test Project' , @ProjectDescription = 'Test Desc'
Exec pInsEmployeeProjectHours @EmployeeName = 'Test User', @ProjectName = 'Test Project', @Date = '1/1/2011', @Hours = 1
GO

Exec pSelEmployeeNames
Exec pSelProjectNames
Exec pSelEmployeeProjectHours
GO


-- 7) Update Sprocs
Create Proc pUpdEmployeeNames
( @EmployeeId int, @EmployeeName varchar(100))
  AS
  Begin
    Declare @RC int = 0
    Begin Try  
	  Begin Transaction  
		Update [dbo].[Employees] 
		Set 
			[EmployeeId] = @EmployeeId, 
			[EmployeeName] = @EmployeeName
		Where 
			[EmployeeId] = @EmployeeId 
			OR 
			[EmployeeName] = @EmployeeName
	  Commit Transaction
	Set @RC = 100 -- Indicates Success			
    End Try
    Begin Catch
		Set @RC = -100 --Indicates Error
		Rollback Transaction
    End Catch	
    Return @RC
  End	
GO

Create Proc pUpdProjectNames
( @ProjectId int, @ProjectName varchar(100),  @ProjectDescription varchar(5000))
  AS
  Begin
    Declare @RC int = 0
    Begin Try  
	  Begin Transaction    
		Update [dbo].[Projects]
		Set 
			[ProjectId] = @ProjectId, 
			[ProjectName] = @ProjectName,
			[ProjectDescription] = @ProjectDescription 			
		Where 
			[ProjectId] = @ProjectId 
			OR 
			[ProjectName] = @ProjectName
			OR 	  
			[ProjectDescription] = @ProjectDescription 		  
	  Commit Transaction
	Set @RC = 100 -- Indicates Success			
    End Try
    Begin Catch
		Set @RC = -100 --Indicates Error
		Rollback Transaction		
    End Catch	
    Return @RC
  End	
GO

Create Proc pUpdEmployeeProjectHours
( @EmployeeName varchar(100), @ProjectName varchar(100), @Date datetime, @Hours decimal(18,2))
  AS
  Begin
    Declare @RC int = 0, @EmployeeId Int = 0, @ProjectId int = 0   
    Begin Try  
    	-- Look up the IDs
		Select @EmployeeId = EmployeeId From dbo.Employees Where EmployeeName = @EmployeeName
		Select @ProjectId = ProjectId From dbo.Projects Where ProjectName = @ProjectName	
    
	  Begin Transaction   
	  	Update [dbo].[EmployeeProjectHours]
		Set 
			[EmployeeId] = @EmployeeId, 
			[ProjectId] = @ProjectId, 
			[Date] = @Date,
			[Hours]= @Hours 			
		Where 
 			[EmployeeId] = @EmployeeId 
 			AND
			[ProjectId] = @ProjectId 
			AND
			[Date] = @Date
	  Commit Transaction		
    End Try
    Begin Catch
		Set @RC = -100 --Indicates Error
		Rollback Transaction			
    End Catch	
    Return @RC
  End	
GO

	-- 7a) Review everything you have so far
	Exec pUpdEmployeeNames @EmployeeId = 3 , @EmployeeName = 'Test User 2' 
	Exec pUpdProjectNames @ProjectId = 103, @ProjectName = 'Test Project 2' , @ProjectDescription = 'Test Desc 2'
	Exec pUpdEmployeeProjectHours @EmployeeName = 'Test User 2',@ProjectName = 'Test Project 2' , @Date = '1/1/2011' , @Hours = 10
	GO
	
	Exec pSelEmployeeNames
	Exec pSelProjectNames
	Exec pSelEmployeeProjectHours
	GO

-- 8) Delete Sprocs
Create Proc pDelEmployeeNames
( @EmployeeId int = -1, @EmployeeName varchar(100) = '')
  AS
  Begin
    Declare @RC int = 0
    Begin Try  
	  Begin Transaction  
		Delete From [dbo].[Employees] 
		Where 
			[EmployeeId] = @EmployeeId 
			OR 
			[EmployeeName] = @EmployeeName
	  Commit Transaction
	Set @RC = 100 -- Indicates Success			
    End Try
    Begin Catch
		Set @RC = -100 --Indicates Error
    End Catch	
    Return @RC
  End	
GO

Create Proc pDelProjectNames
( @ProjectId int = -1, @ProjectName varchar(100) = '',  @ProjectDescription varchar(5000) = '')
  AS
  Begin
    Declare @RC int = 0
    Begin Try  
	  Begin Transaction    
		Delete From [dbo].[Projects]
		Where 
			[ProjectId] = @ProjectId 
			OR 
			[ProjectName] = @ProjectName
			OR 	  
			[ProjectDescription] = @ProjectDescription 		  
	  Commit Transaction
	Set @RC = 100 -- Indicates Success			
    End Try
    Begin Catch
		Set @RC = -100 --Indicates Error
    End Catch	
    Return @RC
  End	
GO

Create Proc pDelEmployeeProjectHours
( @EmployeeName varchar(100), @ProjectName varchar(100), @Date datetime )
  AS
  Begin
    Declare @RC int = 0, @EmployeeId Int = 0, @ProjectId int = 0 

	 -- Look up the IDs
	Select @EmployeeId = EmployeeId From dbo.Employees Where EmployeeName = @EmployeeName
	Select @ProjectId = ProjectId From dbo.Projects Where ProjectName = @ProjectName	

    Begin Try    
	  Begin Transaction     
		Delete From [dbo].[EmployeeProjectHours]
		Where 
 			[EmployeeId] = @EmployeeId 
 			AND
			[ProjectId] = @ProjectId 
			AND
			[Date] = @Date
	  Commit Transaction		
    End Try
    Begin Catch
		Set @RC = -100 --Indicates Error
    End Catch	
    Return @RC
  End	
GO

	-- 8a) Review everything you have so far
	Exec pDelEmployeeNames @EmployeeId = 3 , @EmployeeName = 'Test User 2' 
	Exec pDelProjectNames @ProjectId = 103, @ProjectName = 'Test Project 2' , @ProjectDescription = 'Test Desc 2'
	Exec pDelEmployeeProjectHours @EmployeeName = 'Test User 2' , @ProjectName = 'Test Project 2', @Date = '1/1/2011'
	GO
	
	Exec pSelEmployeeNames
	Exec pSelProjectNames
	Exec pSelEmployeeProjectHours
	GO
	Select Name, Type_desc 
	From Sys.Objects 
	Where type NOT in ('S', 'IT' , 'SQ', 'PK')
	Order by Type