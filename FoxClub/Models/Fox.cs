﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClub.Models
{
    public class Fox
    {
        public string Name { get; private set; }
        public List<string> Tricks { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }

        public Fox(string name)
        {
            Name = name;
            this.Tricks = new List<string>();
            this.Food = "no food";
            this.Drink = "no drink";
        }
    }
}
