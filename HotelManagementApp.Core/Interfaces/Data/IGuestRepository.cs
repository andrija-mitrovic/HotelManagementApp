using HotelManagementApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementApp.Core.Interfaces.Data
{
    public interface IGuestRepository
    {
        Guest InsertGuest(Guest guest);
    }
}
