using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Domain.Entities
{
    public class Adept : User
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string NameAdept { get; set; } = string.Empty;

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string LastnameAdept { get; set; } = string.Empty;

        [Required]
        [StringLength(20, MinimumLength = 11)]
        [RegularExpression(@"^[A-Za-z0-9]+$", ErrorMessage = "Le NISS doit être valide.")]
        public string NissAdept { get; set; } = string.Empty;

        // Lien avec la table Adresse (relation many-to-one)
        public int AddressId { get; set; }

        public Address Address { get; set; } = null!;
    }
}
