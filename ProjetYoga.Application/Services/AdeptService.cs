using ProjetYoga.Application.Interfaces.Repositories;
using ProjetYoga.Application.Interfaces.Services;
using ProjetYoga.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetYoga.Application.DTO;
using ProjetYoga.Domain.Entities;

namespace ProjetYoga.Application.Services
{
    public class AdeptService(IAdeptRepository adeptRepository, IMailer mailer) : IAdeptService
    {
        public User Register(AdeptRegisterDTO dto)
        {

            // verif règles creation adept 

            // enr DB :  insertion Adept

            // envoyer mail à cet Adept ? U ? -> H ?
        }

    }

}
