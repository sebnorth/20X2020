using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZnakLiczby
{
    class Znak
    {
        public static void SprawdzZnakLiczby(int liczba) {

            if (liczba > 0) Console.WriteLine("Dana liczba jest dodatnia");

            else if (liczba < 0) Console.WriteLine("Dana liczba jest ujemna");

            else Console.WriteLine("Podałeś wartość zero");
        }
    }
}
