﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class Dog : Pet
    {
        public override void Walk()
        {
            Console.WriteLine("Dog is walking");
        }
    }
}
