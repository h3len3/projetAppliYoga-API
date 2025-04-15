using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Application.DTO
{
    public class UserRegisterDTO
    {
        [MaxLength(400)]
        [EmailAddress]
        public string email { get; set; } = null!;
        public string password { get; set; } = null!;
    }
}
