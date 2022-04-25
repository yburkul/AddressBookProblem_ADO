USE [AddressBook_Service]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE Add_AddressBookContact
	-- Add the parameters for the stored procedure here
	@First_Name varchar(50),
	@Last_Name varchar(50),
	@Address varchar(200),
    @City varchar(50),
    @State varchar(50),
    @Zip bigint,
    @PhoneNumber bigint,
    @Email varchar(50),
	@Type varchar(50),
	@AddressBookName varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into AddressBook values (@First_Name,@Last_Name,@Address,@City,@State,@Zip,@PhoneNumber,@Email,@Type,@AddressBookName)
END
GO
select * from AddressBook;