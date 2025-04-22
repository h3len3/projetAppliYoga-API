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
    public class AddressService(IAddressRepository addressRepository) : IAddressService
    {
        public Address Register(CreateAddressDTO dto)
        {
            throw new Exception();
        }
    }
}
