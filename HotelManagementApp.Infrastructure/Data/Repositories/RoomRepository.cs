using HotelManagementApp.Core.Interfaces.Data;
using HotelManagementApp.Core.Models;
using System;
using System.Collections.Generic;

namespace HotelManagementApp.Infrastructure.Data.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly IDataAccess _dataAccess;

        public RoomRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public List<Room> GetAvailableRooms(DateTime startDate, DateTime endDate, int roomTypeId)
        {
            return _dataAccess.LoadData<Room, dynamic>("dbo.spRooms_GetAvailableRooms",
                                                        new { StartDate = startDate, EndDate = endDate, RoomTypeId = roomTypeId},
                                                        DbConfig.ConnectionStringName,
                                                        true);
        }
    }
}
