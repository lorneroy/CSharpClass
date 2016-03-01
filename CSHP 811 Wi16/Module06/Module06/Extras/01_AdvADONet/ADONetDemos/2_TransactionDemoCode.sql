/**** Transaction Demo ****/

Use tempdb
-- Drop Table Checking ; Drop Table Savings
Go

Create Table Checking( Acct int, CustId int, Bal decimal(18,6) check (Bal > 0))
Create Table Savings( Acct int, CustId int, Bal decimal(18,6) check (Bal > 0))
Go
-- Add some Money
Insert into Checking Values(123, 1, 100.00)
Insert into Savings Values(567, 1, 100.00)
Go
Select * From Checking
Select * From Savings 
Go

-- Transfer $60
Update Checking Set Bal = Bal - 60 where Acct = 123
Update Savings Set Bal = Bal + 60 where Acct = 567
Go
Select * From Checking
Select * From Savings 
Go

-- Force an overdraw
Update Checking Set Bal = Bal - 60 where Acct = 123
Update Savings Set Bal = Bal + 60 where Acct = 567
Go

-- Check to see what happened???
Select * From Checking
Select * From Savings 
Go

-- Fix the error
Update Savings Set Bal = Bal - 60 where Acct = 567
Select * From Checking
Select * From Savings 
Go

-- Use Transactions to avoid the error in the future
Begin Try
	Begin Transaction
		Update Checking Set Bal = Bal - 60 where Acct = 123
		Update Savings Set Bal = Bal + 60 where Acct = 567
		RaisError('Transaction complete', 10, 1)
	Commit Transaction
End Try
Begin Catch
	RollBack Transaction
	RaisError('Transaction was rolled back', 15, 1)
End Catch

-- Check to see what happened???
Select * From Checking
Select * From Savings 
Go

-- Create a Stored Procedure to handle the transfer...
Create Procedure updTransferMoney
( @CheckingAcct int, @SavingsAcct int, @CustId int, @Amount decimal(18,6) )
as 
Begin Try
	Begin Transaction
		Update Checking Set Bal = Bal - @Amount where Acct = @CheckingAcct
		Update Savings Set Bal = Bal + @Amount where Acct = @SavingsAcct
		RaisError('Transaction complete', 9, 1) -- Info Message
	Commit Transaction
End Try
Begin Catch
	RollBack Transaction
	RaisError('Transaction was rolled back', 15, 1) -- ErrorMessage
End Catch
Go

Exec updTransferMoney
 @CheckingAcct  = 123, @SavingsAcct = 567, @CustId = 1, @Amount = 10
Go
-- Check to see what happened???
Select * From Checking
Select * From Savings 
Go

Exec updTransferMoney
 @CheckingAcct  = 123, @SavingsAcct = 567, @CustId = 1, @Amount = 60
Go
-- Check to see what happened???
Select * From Checking
Select * From Savings 
Go