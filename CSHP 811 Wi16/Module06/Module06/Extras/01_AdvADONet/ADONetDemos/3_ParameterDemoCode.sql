

Use TempDB;
GO
  
Create Proc DivideDemo
  ( @p1 float, @p2 float, @answer float out )  
  AS
   Declare @ReturnCode int;
   Begin
     Begin Try
       Set @answer = @p1 / @p2;
       Set @ReturnCode = 100;
	   Select @answer as [Ans]; -- This is another way to return data
     End Try
     Begin Catch
	   -- Note: Use a Severity of 9 if you don't want the .Net catch block to run.
       Raiserror('There was an error', 9, 1);
       Set @ReturnCode = -100;
     End Catch
     Return @ReturnCode;
   End
GO

  Declare @Value float;
  Declare @RC int;
  Exec @RC = DivideDemo 4, 3, @Value out;
  Print 'The data was: ' + Cast(@Value as Varchar(20));
  Print 'The status was: ' + Cast(@RC as Varchar(20));