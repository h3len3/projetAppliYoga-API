using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Domain.Entities
{
    public class TypeSub
    {
        public int Id_TypeSub { get; set; }
        public string NameTypeSub { get; set; } = null!;
        public string DescriptionTypeSub { get; set; } = null!;
        public decimal Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Relations : 
        // many to many : avec User : 
        public ICollection<UserTypeSub> UserTypeSubs { get; set; }
        // one to many avec GroupSession - FK ds GroupSession
    }

}
