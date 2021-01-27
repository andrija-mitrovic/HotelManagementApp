CREATE TABLE [dbo].[Guests]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [MiddleName] NVARCHAR(50) NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [PhoneNumber] NVARCHAR(50) NOT NULL, 
    [Gender] NCHAR(15) NOT NULL, 
    [EmailAddress] VARCHAR(30) NULL
)
