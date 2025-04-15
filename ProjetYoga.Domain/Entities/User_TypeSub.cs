using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Domain.Entities
{
    public class User_TypeSub
    {
        public int Id_User { get; set; }
        public User User { get; set; }

        public int Id_TypeSub { get; set; }
        public TypeSub TypeSub { get; set; }

        public DateTime DateSub { get; set; }
        public bool Payed { get; set; }

        // Relation avec PaymentMode (one-to-many) - FK : 
        public int Id_PaymentMode { get; set; }
        public PaymentMode PaymentMode { get; set; }
    }

    

}
