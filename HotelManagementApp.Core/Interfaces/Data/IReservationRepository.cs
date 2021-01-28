using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementApp.Core.Interfaces.Data
{
    public interface IReservationRepository
    {
        void AddReservation(int roomId, int guestId, DateTime startDate, DateTime endDate);
    }
}
