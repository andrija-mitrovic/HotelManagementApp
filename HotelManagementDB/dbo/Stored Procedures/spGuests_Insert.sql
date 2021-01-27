CREATE PROCEDURE [dbo].[spGuests_Insert]
	@firstName nvarchar(50),
	@lastName nvarchar(50),
	@middleName nvarchar(50),
	@address nvarchar(50),
	@phoneNumber nvarchar(50),
	@gender nchar(15),
	@emailAddress varchar(30)
AS
BEGIN
	SET NOCOUNT ON;

	IF NOT EXISTS(SELECT 1 FROM Guests WHERE FirstName=@firstName AND LastName=@lastName)
	BEGIN
		INSERT INTO Guests(FirstName,LastName,MiddleName,Address,PhoneNumber,Gender,EmailAddress)
		VALUES (@firstName,@lastName,@middleName,@address,@phoneNumber,@gender,@emailAddress)
	END

	SELECT [Id], [FirstName], [LastName], [MiddleName], [Address], [PhoneNumber], [Gender], [EmailAddress] FROM Guests 
	WHERE FirstName=@firstName AND LastName=@lastName
END
