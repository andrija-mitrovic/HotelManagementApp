using HotelManagementApp.Core.Interfaces.Data;
using HotelManagementApp.Core.Models;
using System.Linq;

namespace HotelManagementApp.Infrastructure.Data.Repositories
{
    public class GuestRepository : IGuestRepository
    {
        private readonly IDataAccess _dataAccess;

        public GuestRepository(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Guest InsertGuest(Guest guest)
        {
            return _dataAccess.LoadData<Guest, dynamic>("dbo.spGuests_Insert",
                                                        new
                                                        {
                                                            FirstName = guest.FirstName,
                                                            LastName = guest.LastName,
                                                            MiddleName = guest.MiddleName,
                                                            Address = guest.Address,
                                                            PhoneNumber = guest.PhoneNumber,
                                                            Gender = guest.Gender,
                                                            EmailAddress = guest.EmailAddress
                                                        },
                                                        DbConfig.ConnectionStringName,
                                                        true).First();
        }
    }
}
