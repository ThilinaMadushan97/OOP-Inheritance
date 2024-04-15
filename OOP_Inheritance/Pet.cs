using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance
{
    internal class Pet
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }

        public virtual void Walk()
        {
            Console.WriteLine("Pet is walking");
        }

    }
}
