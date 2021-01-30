using HotelManagementApp.Core.Interfaces.Data;
using HotelManagementApp.Core.Models;
using System;
using System.Collections.Generic;

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

        public List<ReservationFull> GetReservationsByName(string firstName, string lastName)
        {
            return _dataAccess.LoadData<ReservationFull, dynamic>("dbo.spReservations_Search",
                                                                   new
                                                                   {
                                                                       FirstName = firstName,
                                                                       LastName = lastName,
                                                                       StartDate = DateTime.Now.Date
                                                                   },
                                                                   DbConfig.ConnectionStringName,
                                                                   true);
        }

        public void CheckIn(int id)
        {
            _dataAccess.SaveData("dbo.spReservations_CheckIn",
                                  new
                                  {
                                      ReservationId = id
                                  },
                                  DbConfig.ConnectionStringName,
                                  true);
        }

        public void CheckOut(int id)
        {
            _dataAccess.SaveData("dbo.spReservations_CheckOut",
                                  new
                                  {
                                      ReservationId = id
                                  },
                                  DbConfig.ConnectionStringName,
                                  true);
        }
    }
}
