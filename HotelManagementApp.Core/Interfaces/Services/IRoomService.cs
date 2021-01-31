using HotelManagementApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementApp.Core.Interfaces.Services
{
    public interface IRoomService
    {
        List<Room> GetAvailableRooms(DateTime startDate, DateTime endDate, int roomTypeId);
    }
}
