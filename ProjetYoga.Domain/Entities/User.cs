using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Domain.Entities
{
    public class User
    {
        public int Id_User { get; set; }

        public string Email { get; set; } 

        public string Password { get; set; }


        // Relations : 

        // H -> Adept et Instructor : fait 

        // Many to many avec Event : 
        public ICollection<Reservation> Reservations { get; set; }

        // Many to many avec TypeSub

    }
}
