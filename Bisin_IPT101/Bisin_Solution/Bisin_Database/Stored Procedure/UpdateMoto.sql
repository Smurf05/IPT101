CREATE PROCEDURE [dbo].[UpdateMoto]
	@Brand NVARCHAR(50) NULL, 
    @Color NCHAR(50) NULL, 
    @Model NCHAR(50) NULL, 
    @Engine_Number NCHAR(50) NULL, 
    @Chasis_Number NCHAR(25) NULL
AS
	BEGIN
    UPDATE Bisin_Database
    SET 
    [Color] = @Color,
    [Model] = @Model,
    [Engine_Number] = @Engine_Number,
    [Chasis_Number] = @Chasis_Number
    WHERE [Brand] = @Brand;

    END

