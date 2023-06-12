using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bipeds : Animal
    {

        public Bipeds(string name, bool clever) : base(2, name, clever)
        { }
        public override void Move()
        {
            Console.WriteLine("Marche comme un humain...");
        }

        public override void Eat()
        {
            Console.WriteLine("I a m omnivorous");
        }
    }

    
}
