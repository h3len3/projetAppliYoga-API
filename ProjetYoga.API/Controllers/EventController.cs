﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetYoga.Application.DTO;
using ProjetYoga.Application.Exceptions;
using ProjetYoga.Application.Interfaces.Services;
using ProjetYoga.Application.Services;
using System.Net.Mail;

namespace ProjetYoga.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController(IEventService eventService) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(eventService.GetEvents().Select(e => new EventDTO(e)));
        }

        [HttpPost]
        public IActionResult Post(EventFormDTO dto)
        {
            
                eventService.Register(dto);
                return Created();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, EventFormDTO dto)
        {
            eventService.UpdateEvent(id, dto);
            return Created();
        }

        

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            eventService.DeleteEvent(id);
            return Ok();
        }

        [HttpPost("Booking/{id}")]
        public IActionResult Booking([FromRoute]int id, [FromBody] EventBookingDTO dtoB)
        {
            try
            {
                eventService.Booking(id, dtoB);
                return Ok();
            }
            catch(SmtpException)
            {
                return BadRequest("Email invalide");
            }
            catch (DuplicateReservationException)
            {
                return BadRequest("Déjà enregistré");
            }
        }

    }
}
