using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaJoc
{
    public class Logica
    {
        static string psecreta;
        static string pmostrada;
        static int intentos = 8;

        public static void paraulaSecreta()
        {
            Console.WriteLine("Introduce la palabra secreta:");
            psecreta = Console.ReadLine();
            for (int i = 0; i < psecreta.Length; i++)
            {
                pmostrada = pmostrada + '*';
            }
        }

        public static void jugar()
        {
            string letra;
            do
            {
                Console.WriteLine(pmostrada);
                Console.WriteLine("Introduce una letra:");
                letra = Console.ReadLine();
                if (psecreta.IndexOf(letra) == -1)
                {
                    intentos--;
                    pintarPenjat();
                    if (intentos == 0)
                    {
                        Console.WriteLine("Has perdido");
                        break;
                    }
                }
                else
                {
                    int i = psecreta.IndexOf(letra);
                    pmostrada = pmostrada.Remove(i, 1);
                    pmostrada = pmostrada.Insert(i, letra);
                    Console.WriteLine(pmostrada);
                    if (psecreta.CompareTo(pmostrada) == 0)
                    {
                        Console.WriteLine("Has ganado");
                        break;
                    }
                }
            }
            while (intentos != 0 || pmostrada.IndexOf('*') != -1
                );
        }
        public static void pintarPenjat()
        {
            switch (intentos)
            {
                case '0':
                    Console.WriteLine("");
                    break;
                case '1':
                    Console.WriteLine("");
                    break;
                case '2':
                    Console.WriteLine("");
                    break;
                case '3':
                    Console.WriteLine("");
                    break;
                case '4':
                    Console.WriteLine("");
                    break;
                case '5':
                    Console.WriteLine("");
                    break;
                case '6':
                    Console.WriteLine("");
                    break;
                case '7':
                    Console.WriteLine("");
                    break;
                case '8':
                    Console.WriteLine("");
                    break;
                default:
                    break;
            }
        }
    }
}
