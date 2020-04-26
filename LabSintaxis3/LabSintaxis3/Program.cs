using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cadenas = new string[5];
            int cantIteraciones = 5;
            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.Write("Ingrese un número: ");
                cadenas[i] = Console.ReadLine();
            }
            for (int i = cantIteraciones - 1; i >= 0; i--)
            {
                Console.Write(cadenas[i] + " ");
            }
            Console.ReadKey();        }
    }
}
