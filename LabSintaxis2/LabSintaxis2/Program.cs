using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis2
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTexto;
            inputTexto = Console.ReadLine();
            bool esTexto = false;
            foreach (char c in inputTexto)
            {
                if (char.IsLetter(c))
                {
                    esTexto = true;
                }
                else
                {
                    esTexto = false;
                }

            }

            if (esTexto)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Mostrar texto en mayúsculas.");
                Console.WriteLine("2. Mostrar texto en minúsculas");
                Console.WriteLine("3. Mostrar cantidad de caracteres del texto.");
                ConsoleKeyInfo opcion = Console.ReadKey();
                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        Console.WriteLine(inputTexto.ToUpper());
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine();
                        Console.WriteLine(inputTexto.ToLower());
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine();
                        Console.WriteLine("Cantidad de caracteres: " + inputTexto.Length);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("! Selección inválida.");
                        break;
                }
            }
            else
            {
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
