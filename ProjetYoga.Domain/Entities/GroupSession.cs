using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Domain.Entities
{
    public class GroupSession : Event
    {
        public int Id { get; set; }
        public string DaysAndHours { get; set; } = null!;
        public DateTime StartDateGroupSession { get; set; }
        public DateTime EndDateGroupSession { get; set; }

        // Clé étrangère
        public int Id_TypeSub { get; set; }

        // Navigation vers TypeSub
        public TypeSub TypeSub { get; set; } = null!;
    }
}
