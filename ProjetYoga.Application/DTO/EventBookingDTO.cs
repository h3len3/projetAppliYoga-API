using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Application.DTO
{
    public class EventBookingDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
