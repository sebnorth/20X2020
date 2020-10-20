using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę a - współczynnik równania ax+b=0");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę b - współczynnik równania ax+b=0");
            int b = Convert.ToInt32(Console.ReadLine());

            double wynik = (-b / (double) a);

            // TODO

            // zadanie 15 - równanie kwadratowe

        }
    }
}
