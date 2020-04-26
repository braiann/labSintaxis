using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese una opción del 1 al 9: ");
            ConsoleKeyInfo op = Console.ReadKey();
            Console.WriteLine();
            switch (op.Key)
            {
                case ConsoleKey.D1:
                    Suma();
                    break;
                case ConsoleKey.D2:
                    Bisiesto();
                    break;
                case ConsoleKey.D3:
                    Fibonacci();
                    break;
                case ConsoleKey.D4:
                    Pares();
                    break;
                case ConsoleKey.D5:
                    NumMes();
                    break;
                case ConsoleKey.D6:
                    Romanos();
                    break;
                case ConsoleKey.D7:
                    PrimosGemelos();
                    break;
                case ConsoleKey.D8:
                    IngresoClave();
                    break;
                case ConsoleKey.D9:
                    Triangulo();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
            Console.ReadKey();

            void Suma()
            {
                int a, b;
                Console.Write("Ingrese un número: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Ingrese otro número: ");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("El resultado de la suma de " + a + " y " + b + " es " + (a + b));
            }

            void Bisiesto()
            {
                Console.Write("Ingrese un año: ");
                int año = int.Parse(Console.ReadLine());
                bool esBisiesto = false;
                if (año % 4 == 0)
                {
                    if (año % 100 == 0)
                    {
                        if (año % 400 == 0)
                            esBisiesto = true;
                    }
                    else
                    {
                        esBisiesto = true;
                    }
                }

                if (esBisiesto)
                    Console.WriteLine("El año " + año + " es bisiesto.");
                else
                    Console.WriteLine("El año " + año + " no es bisiesto.");
            }

            void Fibonacci()
            {
                int a = 1;
                int b = 1;
                int c = 1;
                Console.Write("Ingrese un número: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(c);
                    c = a + b;
                    a = b;
                    b = c;
                }
            }

            void Pares()
            {
                for (int i = 1; i < 100; i++)
                {
                    if (i % 2 == 0)
                        Console.WriteLine(i);
                }
            }

            void NumMes()
            {
                string[] meses = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };

                Console.Write("Ingrese el nombre de un mes: ");
                string mes = Console.ReadLine().ToLower();
                for (int i = 0; i < meses.Length; i++)
                {
                    if (meses[i].Equals(mes))
                    {
                        Console.WriteLine(mes + " " + (i + 1));
                        break;
                    }
                }
            }

            void Romanos()
            {
                int[] enteros = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
                string[] romanos = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

                Console.Write("Ingrese un número: ");
                int num = int.Parse(Console.ReadLine());
                string numRomano = "";

                for (int i = 0; i < enteros.Length; i++)
                {
                    int repetir = num / enteros[i];
                    for (int j = 0; j < repetir; j++)
                    {
                        numRomano += romanos[i];
                    }
                    num -= repetir * enteros[i];
                }

                Console.WriteLine("Número romano: " + numRomano);
            }

            void PrimosGemelos()
            {
                Console.Write("Ingrese un número: ");
                int n = int.Parse(Console.ReadLine());
                int i = 1;
                while (i < n)
                {
                    if (EsPrimo(i) && EsPrimo(i - 2))
                    {
                        Console.WriteLine(i - 2 + " y " + i);
                    }
                    
                    
                    i++;
                }
                bool EsPrimo(int número)
                {
                    bool esPrimo = false;
                    for (int j = 2; j < número; j++)
                    {
                        if (número % j == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                        else
                            esPrimo = true;
                    }
                    return esPrimo;
                }
                
            }

            void IngresoClave()
            {
                string clave = "hola";
                int intentos = 0;
                while (intentos < 4)
                {
                    intentos++;
                    Console.Write("Introduzca clave: ");
                    string claveIngresada = Console.ReadLine();
                    if (claveIngresada.Equals(clave))
                    {
                        break;
                    }
                }
            }

            void Triangulo()
            {
                Console.Write("Ingrese el número de filas: ");
                int filas = int.Parse(Console.ReadLine());
                int i = 0;
                while (filas > 0)
                {
                    for (int j = 0; j < (filas - 1); j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < (i + 1) * 2 - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    filas--;
                    i++;
                }
            }
        }
    }
}
