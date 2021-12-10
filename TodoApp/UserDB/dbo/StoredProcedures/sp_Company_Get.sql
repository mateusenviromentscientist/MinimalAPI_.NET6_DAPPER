CREATE PROCEDURE [dbo].[sp_Company_Get]
	@Id int
AS
BEGIN
	SELECT Id,FirstName, LastName, Country
	FROM dbo.[Company]
	WHERE Id = @Id;
END