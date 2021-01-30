CREATE PROCEDURE [dbo].[spReservations_Search]
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@startDate date
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [re].[Id], [re].[RoomId], [re].[GuestId], [re].[StartDate], [re].[EndDate], [re].[CheckedIn], [re].[CheckedOut], [re].[DiscountId],
		   [re].[TotalPayment], [g].[FirstName], [g].[LastName], [g].[MiddleName], [g].[Address], [g].[PhoneNumber], [g].[Gender], 
		   [g].[EmailAddress], [r].[RoomNumber], [r].[RoomFloor], [r].[RoomTypeId], [rt].[Title], [rt].[Description], [rt].[Price] 
	FROM Reservations re
	INNER JOIN Guests g ON g.Id=re.GuestId
	INNER JOIN Rooms r ON r.Id=re.Id
	INNER JOIN RoomTypes rt ON rt.Id=r.RoomTypeId 
	WHERE FirstName=@firstName AND LastName=@lastName AND Re.StartDate=@startDate
END
