CREATE PROCEDURE [dbo].[sp_User_Delete]
	@Id int
AS
BEGIN
	DELETE 
	FROM dbo.[User]
	WHERE Id = @Id;
END