using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizHalmazallapotMero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[A víz halmazállapotának vizsgálata]");
            Console.Write("Hőmérséklet: ");
            double t = Convert.ToDouble(Console.ReadLine());
            if (t>0)
            {
                if (t>100)
                {
                    Console.WriteLine("Gőz!");
                }
                else Console.WriteLine("Víz");
            }
            else Console.WriteLine("Jég");
            Console.ReadKey();
        }
    }
}
