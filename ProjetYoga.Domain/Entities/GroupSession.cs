﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetYoga.Domain.Entities
{
    public class GroupSession : Event
    {


        // Relation : 
        // héritage (enfant de User)
        // avec TypeSub : One to many - FK ds GroupSession

        public override string Type => "GroupSession";
    }
}
