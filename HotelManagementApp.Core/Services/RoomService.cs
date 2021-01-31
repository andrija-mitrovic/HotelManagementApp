using HotelManagementApp.Core.Interfaces.Data;
using HotelManagementApp.Core.Interfaces.Services;
using HotelManagementApp.Core.Models;
using System;
using System.Collections.Generic;

namespace HotelManagementApp.Core.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        public List<Room> GetAvailableRooms(DateTime startDate, DateTime endDate, int roomTypeId)
        {
            return _roomRepository.GetAvailableRooms(startDate, endDate, roomTypeId);
        }
    }
}
