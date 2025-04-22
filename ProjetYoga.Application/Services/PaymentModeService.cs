using ProjetYoga.Application.DTO;
using ProjetYoga.Application.Interfaces.Repositories;
using ProjetYoga.Application.Interfaces.Services;
using ProjetYoga.Application.Interfaces;
using ProjetYoga.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Application.Services
{
    public class PaymentModeService(IPaymentModeRepository paymentModeRepository) : IPaymentModeService
    {
        public PaymentMode Register(CreatePaymentModeDTO dto)
        {
            throw new NotImplementedException();
        }

    }
}
