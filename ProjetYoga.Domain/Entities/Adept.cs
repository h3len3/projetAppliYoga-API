using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Domain.Entities
{
    public class Adept : User
    {    
        public string NameAdept { get; set; } = null!;

        public string LastnameAdept { get; set; } = null!;
        public string NissAdept { get; set; } = null!;
        public string PhoneAdept { get; set; } = null!;

        // Relations :
        // - enfant de User : fait (:User + pas de id)
        // - one to one avec Address FK dans Adept : 
        public int Id_Address { get; set; }
        public Address Address { get; set; }

    }
}
