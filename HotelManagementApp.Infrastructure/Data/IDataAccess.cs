using System.Collections.Generic;

namespace HotelManagementApp.Infrastructure.Data
{
    public interface IDataAccess
    {
        List<T> LoadData<T, U>(string sqlStatement, U parameters, string connectionStringName, bool isStoredProcedure);
        void SaveData<T>(string sqlStatement, T parameters, string connectionStringName, bool isStoredProcedure = false);
    }
}