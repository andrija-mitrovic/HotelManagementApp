CREATE PROCEDURE [dbo].[spRoomTypes_GetAvailableTypes]
	@startDate date,
	@endDate date
AS
BEGIN
	SET NOCOUNT ON;

	SELECT t.Id,t.Title,t.Description,t.Price FROM Rooms r
	INNER JOIN dbo.RoomTypes t ON t.Id=r.RoomTypeId
	WHERE r.Id NOT IN (
	SELECT re.RoomId FROM Reservations re WHERE
	(re.StartDate>@startDate AND re.EndDate<@endDate) OR
	(re.StartDate<=@endDate AND @endDate<re.EndDate) OR
	(re.StartDate<=@startDate AND @startDate<re.EndDate))
	GROUP BY t.Id,t.Title,t.Description,t.Price
END
