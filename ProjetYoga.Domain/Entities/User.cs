﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Domain.Entities
{
    public class User
    {
        public int Id_User { get; set; }

        public string Email { get; set; } 

        public string Password { get; set; } 

        
        // relations à faire : 
        // H -> Adept et Instructor
        // Many to many avec TypeSub
        // Many to many avec Event 
    }
}
