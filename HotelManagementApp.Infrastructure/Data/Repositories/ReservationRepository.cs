using HotelManagementApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementApp.Infrastructure.Data.Repositories
{
    public class ReservationRepository
    {
        private readonly IDataAccess _dataAccess;

        public ReservationRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }


    }
}
