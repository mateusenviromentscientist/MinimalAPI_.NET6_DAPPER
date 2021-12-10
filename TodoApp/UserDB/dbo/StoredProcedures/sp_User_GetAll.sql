CREATE PROCEDURE [dbo].[sp_User_GetAll]
AS
BEGIN
	SELECT Id,FirstName, LastName
	FROM dbo.[User];
END
