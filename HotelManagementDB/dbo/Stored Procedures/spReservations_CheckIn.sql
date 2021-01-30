CREATE PROCEDURE [dbo].[spReservations_CheckIn]
	@id int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE Reservations SET CheckedIn=1 WHERE Id=@id
END
