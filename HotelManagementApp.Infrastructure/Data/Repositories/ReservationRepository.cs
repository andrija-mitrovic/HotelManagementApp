using HotelManagementApp.Core.Interfaces.Data;
using System;

namespace HotelManagementApp.Infrastructure.Data.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly IDataAccess _dataAccess;

        public ReservationRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public void AddReservation(int roomId,int guestId, DateTime startDate, DateTime endDate)
        {
            _dataAccess.SaveData("dbo.spReservations_Insert",
                                  new 
                                  { 
                                      RoomId = roomId, 
                                      GuestId = guestId, 
                                      StartDate = startDate, 
                                      EndDate = endDate 
                                  },
                                  DbConfig.ConnectionStringName,
                                  true);
        }
    }
}
