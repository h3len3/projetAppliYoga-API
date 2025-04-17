using ProjetYoga.Application.DTO;
using ProjetYoga.Application.Exceptions;
using ProjetYoga.Application.Interfaces;
using ProjetYoga.Application.Interfaces.Repositories;
using ProjetYoga.Application.Interfaces.Services;
using ProjetYoga.Application.Utils;
using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ProjetYoga.Application.Services
{
    public class UserService(IUserRepository userRepository, IMailer mailer): IUserService
    {
        public User Register(UserRegisterDTO dto)
        {
            // vérifier email unique
            if (userRepository.Any(u=>u.Email==dto.email))
            {
                throw new DuplicatePropertyException(nameof(dto.email));
            }
            // vérifier règles mot de passe

            // Traitement mdp : 
            Guid salt = Guid.NewGuid();
            string hashedPassword = PasswordUtils.HashPassword(dto.password, salt);

            // Transaction (using ci-dessous + en fin transactionScope.Complete();)
            using TransactionScope transactionScope = new(); 
            //insérer ce user
            User u = userRepository.Add(new User
            {
                Email = dto.email,
                Password = hashedPassword,
                Salt = salt
            });
            // envoyer un mail à ce user
            mailer.Send(u.Email, "Compte créé", $"Bienvenue, par ce mail nous vous confirmons que votre compte a été créé");
            transactionScope.Complete();


            return u; 
        }
    }
}
