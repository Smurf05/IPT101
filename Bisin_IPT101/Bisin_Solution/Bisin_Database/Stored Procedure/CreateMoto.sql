CREATE PROCEDURE [dbo].[CreateMoto]
	@Brand NVARCHAR(50) NULL, 
    @Color NCHAR(50) NULL, 
    @Model NCHAR(50) NULL, 
    @Engine_Number NCHAR(50) NULL, 
    @Chasis_Number NCHAR(25) NULL
AS
	BEGIN
        INSERT INTO [dbo].[Motorcycle] ([Brand], [Color], [Model], [Engine_Number], [Chasis_Number])
        VALUES (@Brand,@Color,@Model,@Engine_Number,@Chasis_Number);
	END