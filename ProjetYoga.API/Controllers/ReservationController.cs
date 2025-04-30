using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetYoga.Application.DTO;
using ProjetYoga.Application.Interfaces.Services;
using ProjetYoga.Application.Services;

namespace ProjetYoga.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController(IReservationService reservationService) : ControllerBase
    {

        [HttpGet]
        public IActionResult GetByEventId([FromQuery] int eventId)
        {
            return Ok(reservationService.GetByEventId(eventId));
        }

    }

    
}
