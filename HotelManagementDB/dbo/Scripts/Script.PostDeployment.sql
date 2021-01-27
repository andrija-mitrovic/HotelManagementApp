/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

if not exists (select 1 from dbo.RoomTypes)
begin
    insert into dbo.RoomTypes(Title, Description, Price)
    values ('King Size Bed', 'A room with a king-size bed and a window.', 100),
    ('Two Queen Size Beds', 'A room with two queen-size beds and a window.', 115),
    ('Executive Suite', 'Two rooms, each with a king-size bed and a window.', 205);
end

if not exists (select 1 from dbo.Rooms)
begin
    declare @roomId1 int;
    declare @roomId2 int;
    declare @roomId3 int;

    select @roomId1 = Id from dbo.RoomTypes where Title = 'King Size Bed';
    select @roomId2 = Id from dbo.RoomTypes where Title = 'Two Queen Size Beds';
    select @roomId3 = Id from dbo.RoomTypes where Title = 'Executive Suite';

    insert into dbo.Rooms (RoomNumber, RoomFloor, RoomTypeId)
    values ('101', 'First', @roomId1),
    ('102', 'First', @roomId1),
    ('103', 'First', @roomId1),
    ('201', 'Second', @roomId2),
    ('202', 'Second', @roomId2),
    ('301', 'Third', @roomId3);
end