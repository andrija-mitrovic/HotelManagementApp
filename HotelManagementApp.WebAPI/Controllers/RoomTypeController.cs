using HotelManagementApp.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HotelManagementApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypeService _roomTypeService;

        public RoomTypeController(IRoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }

        public IActionResult GetAvailableRoomTypes(DateTime startDate, DateTime endDate)
        {
            var roomTypes = _roomTypeService.GetAvailableRoomTypes(startDate, endDate);
            return Ok(roomTypes);
        }
    }
}
