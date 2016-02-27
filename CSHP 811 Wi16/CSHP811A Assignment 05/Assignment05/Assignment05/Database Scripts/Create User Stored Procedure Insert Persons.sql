-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Lorne Roy
-- Create date: 2/26/2016
-- Description:	Stored Procedure for inserting record into Person Table
-- =============================================
CREATE PROCEDURE usp_insert_person 
	-- Add the parameters for the stored procedure here
	@FirstName nvarchar(50) = NULL 
	,@LastName nvarchar(50) = NULL
	,@PhoneNumber varchar(50) = NULL
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	INSERT INTO [dbo].[Persons] ([FirstName],[LastName],[PhoneNumber]) VALUES (@FirstName,@LastName,@PhoneNumber );

END
GO
