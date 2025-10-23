CREATE PROCEDURE [dbo].[DeleteMoto]
	@Brand NVARCHAR(50) = NULL
AS
	BEGIN
		DELETE FROM [dbo].[Motorcycle] WHERE Brand = @Brand;
	END