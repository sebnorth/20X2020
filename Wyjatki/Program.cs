using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            //int X;
            //X = 10 / 0;

            try
            {
                int X, Y, Z;
                X = 10;
                Y = 0;
                Z = X / Y;
            }
            catch (Exception uchwyt)
            {

                // throw;
                Console.WriteLine("Komunikat o wyjątku: {0}", uchwyt.Message);
            }

            finally
            {

                Console.WriteLine("Program rusza dalej.");
            }


        }
    }
}
