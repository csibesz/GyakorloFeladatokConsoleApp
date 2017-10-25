using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontokTavolsaga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Első pont x koordinátája:");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Első pont y koordinátája:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Második pont x koordinátája:");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Második pont y koordinátája:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double tavolsag = Math.Sqrt ((x1-x2)*(x1-x2)+(y2-y1)*(y2-y1));
            Console.Write("Távolság: {0}", tavolsag);
            Console.ReadKey();
        }
    }
}
