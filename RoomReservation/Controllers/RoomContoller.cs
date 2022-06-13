﻿using Microsoft.AspNetCore.Mvc;
using RoomReservation.DTOs;
using RoomReservation.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class RoomContoller : Controller
    {
        private IRoomService _service;

        public RoomContoller(IRoomService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int Id)
        {
            var response = _service.Get(Id);

            if (response == null) return NotFound();

            return Ok(response);
        }

        [HttpGet()]
        public IActionResult GetAll()
        {
            var response = _service.GetAll();
            return Ok(response);
        }

        [HttpPost()]
        public IActionResult Create([FromBody] RoomDTO roomDto)
        {
            if (roomDto == null) return BadRequest();

            _service.Create(roomDto);

            return Ok();
        }

        [HttpPut()]
        public IActionResult Update([FromBody] RoomDTO roomDto)
        {
            if (roomDto == null) return BadRequest();

            _service.Update(roomDto);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int Id)
        {
            _service.Delete(Id);

            return Ok();
        }
    }
}
