using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CS_lessen
{
    //silver Les 2: LinearSearch
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]
			{
				"Joe",
				"Rick",
				"Sam",
				"Giovanni",
				"Ramses",
				"Laura",
				"Laurens",
				"Lydia",
				"Eric",
				"Rose"
			};
			string nameToFind = "Joe";
			FindStringIndex(nameToFind, names);
			Console.ReadKey();
        }
		public static void FindStringIndex(string nameToFind, string[] names)
		{
			for(int i = 0; i < names.Lenght; i++)
			{
				if(names[i] == nameToFind) 
				{
					Console.WriteLine($"Joe zit op index: {i}");
				}
			}
		}
    }
}
