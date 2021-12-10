CREATE PROCEDURE [dbo].[sp_User_Get]
	@Id int
AS
BEGIN
	SELECT Id,FirstName, LastName
	FROM dbo.[User]
	WHERE Id = @Id;
END