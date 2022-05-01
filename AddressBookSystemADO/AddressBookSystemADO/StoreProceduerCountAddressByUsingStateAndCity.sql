Use[AddressBook_Service]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

alter PROCEDURE [spCountAddressByUsingCityAndState] 
	-- Add the parameters for the stored procedure here
	--@First_Name varchar (50),
	@City varchar(50),
	@State  varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * From AddressBook where City = @City And State = @State;
	select * from AddressBook
END
GO
