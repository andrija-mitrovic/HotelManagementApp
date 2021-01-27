CREATE PROCEDURE [dbo].[spRooms_GetAvailableRooms]
	@startDate date,
	@endDate date,
	@roomTypeId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT r.*
	FROM dbo.Rooms r
	INNER JOIN dbo.RoomTypes t ON t.Id=r.RoomTypeId
	WHERE r.RoomTypeId = @roomTypeId
	AND r.Id NOT IN (
	SELECT re.RoomId 
	FROM Reservations re WHERE
		(re.StartDate>@startDate AND re.EndDate<@endDate) OR
		(re.StartDate<=@endDate AND @endDate<re.EndDate) OR
		(re.StartDate<=@startDate AND @startDate<re.EndDate)
	)
END
