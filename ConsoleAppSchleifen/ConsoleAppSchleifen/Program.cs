using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSchleifen
{
    class Program
    {
        private static int zähler = 50;
        private static int i;

        static void Main(string[] args)
        {
            while (zähler >= 40)
            {
                Console.WriteLine("Die Glühbirne hat " + zähler + " Watt.");
                zähler--;
            }
            Console.WriteLine("__________________________________");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Die Glühbirne hat " + zähler + " Watt.");
                zähler++;
            }
            while (zähler <= 60);

            Console.WriteLine("__________________________________");
            Console.WriteLine();
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("Die Glühbirne hat " + i + " Watt.");
            }
            Console.WriteLine("__________________________________");
            Console.ReadKey();
        }
    }
}