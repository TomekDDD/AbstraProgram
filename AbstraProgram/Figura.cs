using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraProgram
{
    abstract class Figura
    {

        public abstract double Pole();
        public abstract double Obwod();
        public virtual void Pokaz()
        {
        Console.WriteLine($"Pole:{Pole()} Obwód: {Obwod()}\n");
        }

        
    }
}
