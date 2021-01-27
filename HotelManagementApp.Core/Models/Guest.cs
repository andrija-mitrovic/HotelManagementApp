﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementApp.Core.Models
{
    public class Guest
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string EmailAddress { get; set; }
    }
}
