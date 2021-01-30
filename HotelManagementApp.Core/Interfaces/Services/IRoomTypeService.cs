using HotelManagementApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementApp.Core.Interfaces.Services
{
    public interface IRoomTypeService
    {
        List<RoomType> GetAvailableRoomTypes(DateTime startDate, DateTime endDate);
    }
}
