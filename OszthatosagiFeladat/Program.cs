using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OszthatosagiFeladat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérek egy számot: ");
            string n = Console.ReadLine();
            Console.WriteLine();
            int hossz = n.Length;
            int osszeg = 0;
            for (int i = 0; i < hossz; i++)
            {
                osszeg = osszeg + Convert.ToInt32(n[i]) - 48;
            }
            if (osszeg % 3 == 0)
            {
                Console.WriteLine("A szám osztható 3-mal.");
            }
            else Console.WriteLine("A szám nem osztható 3-mal.");
            if (osszeg % 9 == 0)
            {
                Console.WriteLine("A szám osztható 9-el.");
            }
            else Console.WriteLine("A szám nem osztható 9-el.");
            if (hossz > 1)
            {
                if (Convert.ToInt32(n[hossz - 2] - 48) * 10 + Convert.ToInt32(n[hossz - 1] - 48) % 4 == 0)
                {
                    Console.WriteLine("A szám osztható 4-gyel.");
                }
                else Console.WriteLine("A szám nem osztható 4-gyel.");
            }
            else if ((Convert.ToInt32(n[0]) - 48) % 4 == 0)
            {
                Console.WriteLine("A szám osztható 4-gyel.");
            }
            else Console.WriteLine("A szám nem oszható 4-gyel.");
            Console.ReadKey();
        }
    }
}
