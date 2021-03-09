using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CS_lessen
{
    //silver Les 3: Classes
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"10 + 5 = {Rekenmachine.Optellen(10, 5)}");
            Console.WriteLine($"10 / 5 = {Rekenmachine.Delen(10, 5)}");
            Console.WriteLine($"10 x 5 = {Rekenmachine.Vermenigvuldigen(10, 5)}");
            Console.ReadKey();
        }
    }
    class Rekenmachine
    {
        public static int Optellen(int getal1, int getal2)
        {
            return getal1 += getal2;
        }
        public static int Delen(int getal1, int getal2)
        {
            return getal1 /= getal2;
        }
        public static int Vermenigvuldigen(int getal1, int getal2)
        {
            return getal1 *= getal2;
        }
    }
}
