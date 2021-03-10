using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Voer een getal in \n");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int number))
                {
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine("Dit is de eerste case \n");
                            break;
                        case 2:
                            Console.WriteLine("Dit is de tweede case \n");
                            break;
                        default:
                            Console.WriteLine("Dit is de default case \n");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"{input} is geen geldig getal \n");
                }
            }
        }
    }
}
