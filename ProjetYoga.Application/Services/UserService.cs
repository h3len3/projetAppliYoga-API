using ProjetYoga.Application.DTO;
using ProjetYoga.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Application.Services
{
    public class UserService(IUserRepository userRepository)
    {
        public UserService Register(UserRegisterDTO dto)
        {
        }
    }
}
