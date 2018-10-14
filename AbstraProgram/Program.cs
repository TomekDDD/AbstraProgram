using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Kwadrat MojNowyK = new Kwadrat(7);
            Console.WriteLine("Obwód Kwadratu: {0}", MojNowyK.Obwod());
            Console.WriteLine($"Pole Kwadratu:{MojNowyK.Pole()}");
            Console.WriteLine($"Przekątna Kwadratu:{MojNowyK.Przekatna()}");

            Kolo MojeNoweK = new Kolo(3);
            Console.WriteLine($"Obwód Koła:{MojeNoweK.Obwod()}");
            Console.WriteLine($"Pole Koła:{MojeNoweK.Pole()}");

            Trojkat MojNowyT = new Trojkat(4, 3);
            Console.WriteLine("Obwód Trójkąt: {0}", MojNowyT.Obwod());
            Console.WriteLine($"Pole Trójkąt:{MojNowyT.Pole()}");
            Console.WriteLine($"Przeciwprostokątkna Trójkąt:{MojNowyT.PrzeciwP()}");

            Prostokat MojNowyP = new Prostokat(4, 2);
            Console.WriteLine("Obwód Prostokąt: {0}", MojNowyP.Obwod());
            Console.WriteLine($"Pole Prostokąt:{MojNowyP.Pole()}");
            Console.WriteLine($"Przekątna Prostokąt:{MojNowyP.Przekatna()}");



            //Console.ReadLine();


            Figura[] figury = new Figura[8];

            figury[0] = new Kwadrat(7);
            figury[1] = new Kwadrat(4);
            figury[2] = new Kolo(3);
            figury[3] = new Kolo(4);
            figury[4] = new Trojkat(4, 3);
            figury[5] = new Trojkat(5, 6);
            figury[6] = new Prostokat(4, 2);
            figury[7] = new Prostokat(2, 3);



            foreach (Figura figura in figury)
            {

                figura.Pokaz();
            }

            Console.ReadLine();

        }
    }
}
