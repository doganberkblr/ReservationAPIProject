using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelReservationApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : Controller
    {
        [HttpGet]
        public IActionResult StaffList()
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult AddStaff()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteStaff()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff()
        {
            return Ok();
        }
    }
}

