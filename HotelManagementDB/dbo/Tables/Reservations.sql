CREATE TABLE [dbo].[Reservations]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [RoomId] INT NOT NULL, 
    [GuestId] INT NOT NULL, 
    [StartDate] DATE NOT NULL, 
    [EndDate] DATE NOT NULL, 
    [CheckedIn] BIT NOT NULL DEFAULT 0, 
    [CheckedOut] BIT NOT NULL DEFAULT 0, 
    [DiscountId] INT NOT NULL, 
    [TotalPayment] MONEY NOT NULL, 
    CONSTRAINT [FK_Reservations_Rooms] FOREIGN KEY (RoomId) REFERENCES Rooms(Id), 
    CONSTRAINT [FK_Reservations_Guests] FOREIGN KEY (GuestId) REFERENCES Guests(Id), 
    CONSTRAINT [FK_Reservations_Discounts] FOREIGN KEY (DiscountId) REFERENCES Discounts(Id)
)
