using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizCodigo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, AUX, DEC, UNI;
            string linea;
            Console.WriteLine("Enter 2 digits");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            DEC = NUM / 10;
            UNI = NUM % 10;
            AUX = (UNI * 10) + DEC;
            Console.WriteLine("The number inested will be: " + AUX);
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
    }
}
