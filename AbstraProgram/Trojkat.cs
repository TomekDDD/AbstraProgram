using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraProgram
{
    class Trojkat : Figura
    {
        public int A { get; private set; }

        public int B { get; private set; }

        public Trojkat(int a, int b)
        {
            A = a;
            B = b;

        }

        public override double Pole()
        {
            return (A*B)/2;
            
        }

        public override double Obwod()
        {

            double C = Math.Sqrt((Math.Pow(A, 2)) + (Math.Pow(B, 2)));
            return A + B + C;


        }

        public double PrzeciwP()
        {

            return Math.Sqrt((Math.Pow(A, 2)) + (Math.Pow(B, 2)));

        }
    
       

    }



}
