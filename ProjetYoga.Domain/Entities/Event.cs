using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Domain.Entities
{
    public class Event
    {
        public int  Id { get; set; } // ID unique
        public string Title { get; set; } = null!; // Non nullable
    }
}
