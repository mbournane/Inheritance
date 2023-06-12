using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Quadrupeds : Animal
    {
        public Quadrupeds(string name, bool clover) : base(4, name, clover)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Marche à quatre pattes....");
        }
        public override void Eat()
        {
            Console.WriteLine(" i a m  carnivorous or herbivore");
         
        }
    }
}
