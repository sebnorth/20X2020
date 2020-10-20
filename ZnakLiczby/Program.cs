using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZnakLiczby
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Podaj liczbę: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            Znak.SprawdzZnakLiczby(-40);
            Znak.SprawdzZnakLiczby(0);
            Znak.SprawdzZnakLiczby(5);

            Console.ReadKey();
        }
    }
}
