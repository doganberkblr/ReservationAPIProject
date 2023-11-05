﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelReservationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : Controller
    {

        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _roomService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            _roomService.TInsert(room);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var values = _roomService.TGetByID(id);
            _roomService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            _roomService.TUpdate(room);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var values = _roomService.TGetByID(id);
            return Ok(values);
        }
    }
}

