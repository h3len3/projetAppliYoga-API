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
        // K:
        //public List<Reservation> GetByEventId(int eventId)
        //{
        //    return reservationRepository.FindAllByEventId(eventId);
        //}


        //public List<ReservationDto> GetByEventId(int eventId)
        //{
        //    var reservations = reservationRepository.FindAllByEventId(eventId);

        //    return reservations.Select(r => new ReservationDto
        //    {
        //        Id_Event = r.Id_Event,
        //        Id_User = r.Id_User,
        //        Email = r.User?.Email 
        //    }).ToList();
        //}

        public List<ReservationDTO> GetByEventId(int eventId)
        {
            var reservations = reservationRepository.FindAllByEventId(eventId);

            return reservations.Select(r => new ReservationDTO
            {
                Id_Event = r.Id_Event,
                Id_User = r.Id_User,
                Email = r.User?.Email,
                DateReservation = r.DateReservation,
                PaymentModeId = r.PaymentModeId,
                Payed = r.Payed
            }).ToList();
        }
    }
}

