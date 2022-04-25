USE[AddressBook_Service]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Alter PROCEDURE [spEditContact]
	-- Add the parameters for the stored procedure here
	@First_Name varchar(50),
	@Last_Name varchar(50),
	@Address varchar(200),
    @City varchar(50),
    @State varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	update AddressBook set Last_Name = @Last_Name,Address = @Address, City = @City, State = @State where First_Name = @First_Name;

    -- Insert statements for procedure here
	select * from AddressBook 
END
GO
