using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JawnaKonwersja
{
    class Program
    {
        static void Main(string[] args)
        {
            short s = byte.MaxValue + 2;
            byte b;
            //byte b = s; //błąd, musi być konwersja jawna byte
            b = (byte)s;
            Console.WriteLine(b);


        }
    }
}
