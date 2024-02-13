using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizCodigo1
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI = 3.14;
            double Height, Radius, CurveSurfaceArea, TotalSurfaceArea;
            Console.WriteLine("enter the height of the cylinder: ");
            Height = Convert.ToDouble(Console.ReadLine());
            Console.Write("enter the darius of the cylinder: ");
            Radius = Convert.ToDouble(Console.ReadLine());
            CurveSurfaceArea = 2 * PI * Radius * Height;
            TotalSurfaceArea = 2 * PI * Radius * (Height + Radius);
            Console.WriteLine($"curved surface area of the cylinder:{CurveSurfaceArea}");
            Console.WriteLine($"Totla surface area of the cylinder :{TotalSurfaceArea}");
            Console.ReadKey();
        }
    }
}
