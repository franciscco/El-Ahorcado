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
        static int intentos = 8;

        public static void paraulaSecreta()
        {            
            Console.WriteLine("Introduce la palabra secreta:");
            psecreta = Console.ReadLine();
            string pmostrada = "";
            for (int i = 0; i < psecreta.Length; i++)
            {
                pmostrada[i] = '*';
            }
        }

        public static void jugar()
        {
            Console.WriteLine("Introduce una letra:");
            string letra = Console.ReadLine();
            if (psecreta.IndexOf(letra) == -1)
            {
                intentos--;
                pintarPenjat();
                if (intentos == 0)
                    Console.WriteLine("Has perdido");
            }
            else
            {
                pmostrada[psecreta.IndexOf(letra)] = letra;
                Console.WriteLine(pmostrada);
                if (psecreta.CompareTo(pmostrada) == 0)
                    Console.WriteLine("Has ganado");
            }
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
