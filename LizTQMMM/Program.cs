using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizTQMMM
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, AUX, DEC, UNI;
            string linea;
            Console.WriteLine("INGRESE DOS CIFRAS");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            DEC = NUM / 10;
            UNI = NUM % 10;
            AUX = (UNI * 10) + DEC;
            Console.WriteLine("EL NUMERO INVERTIDO SERA: " + AUX);
            Console.Write("Pulse cualquier tecla");
            Console.ReadLine();
        }
    }
}