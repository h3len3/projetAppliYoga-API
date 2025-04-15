using ProjetYoga.Application.DTO;
using ProjetYoga.Application.Exceptions;
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
            // vérifier email unique
            if (userRepository.Any(u=>u.Email==dto.email))
            {
                throw new DuplicatePropertyException(nameof(dto.email));
            }
            // vérifier règles mot de passe
            //insérer ce user
            userRepository.Add(new Domain.Entities.User
            {
                Email = dto.email,
                Password = dto.password
            });
            // envoyer un mail à ce user
        }
    }
}
