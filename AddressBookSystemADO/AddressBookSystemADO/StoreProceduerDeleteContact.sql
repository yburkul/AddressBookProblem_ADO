Use[AddressBook_Service]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

alter PROCEDURE [spDeleteContactFormAddressBook]
@First_Name varchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
      Delete from AddressBook where First_Name = @First_Name
	  select * from AddressBook
END
GO
