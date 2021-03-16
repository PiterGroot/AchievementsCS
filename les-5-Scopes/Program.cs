using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSlesoprdrachten
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i < 50)
                {
                    Console.WriteLine("Laag");

                }
                else
                {
                    Console.WriteLine("Hoog");
                }
            }
            Console.ReadKey();
        }
    }
}
