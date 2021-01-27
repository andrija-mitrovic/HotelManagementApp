using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementApp.Core.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public string RoomFloor { get; set; }
        public int RoomTypeId { get; set; }
    }
}
