CREATE PROCEDURE [dbo].[sp_Company_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Country nvarchar(50)
AS

BEGIN
	INSERT INTO dbo.[Company] (FirstName, LastName,Country)
	VALUES (@FirstName,@LastName,@Country);
END
