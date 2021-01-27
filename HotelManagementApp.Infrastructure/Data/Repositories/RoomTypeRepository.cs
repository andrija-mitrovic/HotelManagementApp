using HotelManagementApp.Core.Interfaces;
using HotelManagementApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementApp.Infrastructure.Data.Repositories
{
    public class RoomTypeRepository
    {
        private readonly IDataAccess _dataAccess;

        public RoomTypeRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public List<RoomType> GetAvailableRoomTypes(DateTime startDate, DateTime endDate)
        {
            return _dataAccess.LoadData<RoomType, dynamic>("dbo.spRoomTypes_GetAvailableTypes",
                                                            new { StartDate = startDate, EndDate = endDate },
                                                            DbConfig.ConnectionStringName, 
                                                            true);
        }
    }
}
