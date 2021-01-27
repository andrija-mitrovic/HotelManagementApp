using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementApp.Core.Models
{
    public class RoomType
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Money { get; set; }
    }
}
