CREATE PROCEDURE [dbo].[sp_Company_Delete]
	@Id int
AS
BEGIN
	DELETE 
	FROM dbo.[Company]
	WHERE Id = @Id;
END