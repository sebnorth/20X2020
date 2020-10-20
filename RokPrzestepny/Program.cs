using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokPrzestepny
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rok: ");
            // int.TryParse(Console.ReadLine(), out int rok);
            ushort.TryParse(Console.ReadLine(), out ushort rok);

            if ((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
            {
                Console.WriteLine($"Rok {rok} jest przestępny");
            }

            else

            {
                Console.WriteLine($"Rok {rok} nie jest przestępny");
            }
        }
    }
}
