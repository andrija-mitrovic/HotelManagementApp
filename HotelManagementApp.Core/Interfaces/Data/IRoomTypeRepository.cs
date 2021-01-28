using HotelManagementApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementApp.Core.Interfaces.Data
{
    public interface IRoomTypeRepository
    {
        List<RoomType> GetAvailableRoomTypes(DateTime startDate, DateTime endDate);
        RoomType GetRoomTypeId(int id);
    }
}
