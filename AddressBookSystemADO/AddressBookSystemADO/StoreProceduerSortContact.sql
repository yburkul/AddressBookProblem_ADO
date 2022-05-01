USE[AddressBook_Service]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

alter PROCEDURE spSortAlphabetically
@City varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	select * from AddressBook where @City = City order by First_Name ASC
END
GO
