using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Animal
    {
        protected short _legsCount;        
        private string _name;
        protected bool _clever;

        public Animal(short legsCount, string name, bool clever)
        {
            _legsCount = legsCount;
            _name = name;
            _clever = clever;
            if(clever) { Console.WriteLine("I a m a humain"); }
        }
        public virtual void Eat()
        {
            Console.WriteLine("I eat");
            
        }

        public  virtual void Move()
        {
            Console.WriteLine("Moving...");
        }
        public string GetName()
        {
            return _name;
        }
    }
}
