using HotelManagementApp.Core.Interfaces.Data;
using HotelManagementApp.Core.Interfaces.Services;
using HotelManagementApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagementApp.Core.Services
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _reservationRepository;
        private readonly IGuestRepository _guestRepository;
        private readonly IRoomRepository _roomRepository;

        public ReservationService(
            IReservationRepository reservationRepository,
            IGuestRepository guestRepository,
            IRoomRepository roomRepository)
        {
            _reservationRepository = reservationRepository;
            _guestRepository = guestRepository;
            _roomRepository = roomRepository;
        }

        public void AddReservation(Guest guest, int roomTypeId, DateTime startDate, DateTime endDate)
        {
            _guestRepository.InsertGuest(guest);

            List<Room> availableRooms = _roomRepository.GetAvailableRooms(startDate, endDate, roomTypeId);

            _reservationRepository.AddReservation(availableRooms.First().Id, guest.Id, startDate, endDate);
        }
    }
}
