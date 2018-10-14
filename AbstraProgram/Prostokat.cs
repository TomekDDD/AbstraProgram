using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraProgram
{
    class Prostokat : Figura
    {
        public int A { get; private set; }

        public int B { get; private set; }

        public Prostokat(int a, int b)
        {
            A = a;
            B = b;

        }

        public override double Pole()
        {
            return A*B;
            
        }

        public override double Obwod()
        {

            return (2*A) + (2*B);


        }

        public double Przekatna()
        {

            return Math.Sqrt((Math.Pow(A, 2)) + (Math.Pow(B, 2)));

        }
    
       

    }



}
