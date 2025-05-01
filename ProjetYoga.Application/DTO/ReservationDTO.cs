using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Application.DTO
{
    public class ReservationDTO
    {
        public int Id_Event { get; set; }
        public int Id_User { get; set; }
        public string Email { get; set; } = null!;
        public DateTime DateReservation { get; set; } = DateTime.Now;

        public int PaymentModeId { get; set; } = 1;

        public bool Payed { get; set; } = false;
    }
}
