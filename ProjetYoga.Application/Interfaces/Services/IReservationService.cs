using ProjetYoga.Application.DTO;
using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Application.Interfaces.Services
{
    public interface IReservationService
    {
        //List<Reservation> GetByEventId(int eventId);
        List<ReservationDTO> GetByEventId(int eventId);
    }
}
