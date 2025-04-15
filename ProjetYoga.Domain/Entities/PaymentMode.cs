using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Domain.Entities
{
    public class PaymentMode
    {
        public int Id_PaymentMode { get; set; }
        public string Name_PaymentMode { get; set; }

        public ICollection<Reservation> Reservations { get; set; }

        public ICollection<User_TypeSub> User_TypeSubs { get; set; }
    }
}
