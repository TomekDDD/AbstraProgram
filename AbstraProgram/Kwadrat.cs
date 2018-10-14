using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraProgram
{
    class Kwadrat : Figura
    {
        public int A { get; private set; }


        public Kwadrat(int a)
        {
            A = a;

        }


        public override double Obwod()
        {
            return 4*A;
            

        }

        public override double Pole()
        {
            //return A*A;
            return Math.Pow(A, 2);
        }

        public double Przekatna()
        {

            return Math.Sqrt((Math.Pow(A, 2)) + (Math.Pow(A, 2)));


        }

    }



}
