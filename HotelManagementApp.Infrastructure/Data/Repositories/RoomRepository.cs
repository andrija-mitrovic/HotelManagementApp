using HotelManagementApp.Core.Interfaces;
using HotelManagementApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementApp.Infrastructure.Data.Repositories
{
    public class RoomRepository
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
