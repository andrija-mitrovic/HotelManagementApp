using HotelManagementApp.Core.Interfaces.Data;
using HotelManagementApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagementApp.Infrastructure.Data.Repositories
{
    public class RoomTypeRepository : IRoomTypeRepository
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

        public RoomType GetRoomTypeId(int id)
        {
            return _dataAccess.LoadData<RoomType, dynamic>("SELECT * FROM dbo.RoomTypes WHERE Id=@Id",
                                                            new { Id = id },
                                                            DbConfig.ConnectionStringName,
                                                            false).First();
        }
    }
}
