using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeletlenSzamokatGeneraloProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem az első számot: ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kérem a második számot: ");
            int szam2 = int.Parse(Console.ReadLine());

            Random veletlen = new Random();

            Console.WriteLine("A generált számok: {0}, {1}, {2}.", veletlen.Next(szam1, szam2), veletlen.Next(szam1,szam2), veletlen.Next(szam1, szam2));
            Console.ReadKey();
        }
    }
}
