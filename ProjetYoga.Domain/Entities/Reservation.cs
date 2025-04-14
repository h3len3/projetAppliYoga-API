using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Domain.Entities
{
    public class Reservation
    {
        public int Id_User { get; set; }
        public User User { get; set; }

        public int Id_Event { get; set; }
        public Event Event { get; set; }

        public DateTime DateReservation { get; set; }
        public string PaymentMode { get; set; }
        public bool Payed { get; set; }
    }
}
