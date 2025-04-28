using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Application.DTO
{
    public class CreateAddressDTO
    {
        public string Street { get; set; }
        public int NumberStreet { get; set; }

        public string City { get; set; }
        public string PostalCode { get; set; }

        public string Country { get; set; }
    }
}
