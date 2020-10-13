using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBasico7
{
    class EjercicioBasico7
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.Clear();
            Char letra = 'a';
            Console.ForegroundColor = ConsoleColor.Green;
            Int16 incremento_letra = 0;
            Console.WriteLine("    1   2   3   4   5   6   7   8");
            Console.WriteLine("  ---------------------------------");
            do
            {
                Console.Write(((Char)(letra + incremento_letra)) + " |");
                Int16 columna = 0;

                do
                {
                    if (incremento_letra % 2 == 0)
                    {
                        if (columna % 2 == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write("   ");

                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write("   ");
                        }

                    }
                    else
                    {
                        if (columna % 2 == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write("   ");

                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write("   ");
                        }

                    }
 
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("|");
                    columna++;
                } while (columna < 8);
                Console.WriteLine();
                Console.WriteLine("  ---------------------------------");

                incremento_letra++;

            } while (incremento_letra < 8);
            Console.WriteLine("Introduzca coordenadas del alfil:");
            String aux;
            Char fila_alfil;
            do
            {
                Console.Write("Fila: ");
                aux = Console.ReadLine();
                fila_alfil = aux[0];
            } while ((fila_alfil < 'a')
                     || (fila_alfil > 'h') || aux.Length != 1);
            Int32 columna_alfil;
            do
            {
                Console.Write("Columna: ");
                aux = Console.ReadLine();
                columna_alfil = aux[0] - 47;
            } while ((columna_alfil < 1 || columna_alfil > 8) || aux.Length != 1);

            incremento_letra = 0;

            Console.WriteLine("    1   2   3   4   5   6   7   8");
            Console.WriteLine("  ---------------------------------");
            do
            {
                Console.Write(((Char)(letra + incremento_letra)) + " |");
                Int16 columna = 0;

                do
                {
                    if (incremento_letra % 2 == 0)
                    {
                        if (columna % 2 == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;

                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                        }

                    }
                    else
                    {
                        if (columna % 2 == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;

                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                        }

                    }
                    if (columna == columna_alfil && fila_alfil == (letra + incremento_letra))
                    {
                        Console.Write(" A ");
                    }
                    else if (Math.Abs(columna_alfil - columna) == Math.Abs(fila_alfil - (letra + incremento_letra)))
                    {
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.Write("   ");
                    }

                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write("|");
                    columna++;
                } while (columna < 8);
                Console.WriteLine();
                Console.WriteLine("  ---------------------------------");

                incremento_letra++;

            } while (incremento_letra < 8);

            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();

        }

    }
}
