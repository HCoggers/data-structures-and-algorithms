﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public abstract class Animal
    {
        public Animal Next { get; set; }
        public int Id { get; set; }
    }
}
