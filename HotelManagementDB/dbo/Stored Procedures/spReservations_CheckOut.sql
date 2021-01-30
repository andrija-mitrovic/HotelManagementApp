CREATE PROCEDURE [dbo].[spReservations_CheckOut]
	@id int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE Reservations SET CheckedOut=1 WHERE Id=@id
END
