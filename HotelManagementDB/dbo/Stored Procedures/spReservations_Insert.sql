CREATE PROCEDURE [dbo].[spReservations_Insert]
	@roomId int,
	@guestId int,
	@startDate date,
	@endDate date
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Reservations (RoomId,GuestId,StartDate,EndDate)
	VALUES (@roomId,@guestId,@startDate,@endDate)
END
