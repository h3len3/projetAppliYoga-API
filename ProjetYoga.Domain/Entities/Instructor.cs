using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Domain.Entities
{
    public class Instructor : User
    {
        public string Nickname { get; set; } = "Instructor";  // Valeur par défaut "Instructor"
    }
}
