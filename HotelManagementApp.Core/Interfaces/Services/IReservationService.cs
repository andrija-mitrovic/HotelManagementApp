using HotelManagementApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementApp.Core.Interfaces.Services
{
    public interface IReservationService
    {
        void AddReservation(Guest guest, int roomTypeId, DateTime startDate, DateTime endDate);
    }
}
