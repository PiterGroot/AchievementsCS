using System;

namespace Functie
{
    //gold
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"RandomNumber = {GetRandomInt()}");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static int GetRandomInt()
        {
            Random rand = new Random();
            return rand.Next(1, 21);
        }
    }
}
