using ProjetYoga.Application.DTO;
using ProjetYoga.Application.Interfaces;
using ProjetYoga.Application.Interfaces.Repositories;
using ProjetYoga.Application.Interfaces.Services;
using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Application.Services
{
    public class ReservationService(IReservationRepository reservationRepository) : IReservationService
    {
        public List<Reservation> GetByEventId(int eventId)
        {
            return reservationRepository.FindAllByEventId(eventId);
        }
    }
}
