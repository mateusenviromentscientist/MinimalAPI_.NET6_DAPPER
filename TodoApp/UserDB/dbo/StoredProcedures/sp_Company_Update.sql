CREATE PROCEDURE [dbo].[sp_Company_Update]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Country nvarchar(50)
AS
BEGIN
	UPDATE dbo.[Company]
	SET FirstName = @FirstName, LastName = @LastName, Country = @Country
	WHERE Id = @Id;
END