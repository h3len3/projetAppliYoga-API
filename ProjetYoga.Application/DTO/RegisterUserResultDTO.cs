using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Application.DTO
{
    public class RegisterUserResultDTO(User u)
    {
        public int Id_User { get; set; } = u.Id_User;
        // public string Email { get; set; } = u.Email;
       
    }
}
