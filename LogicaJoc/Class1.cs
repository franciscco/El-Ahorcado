using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaJoc
{
    public class Logica
    {
        static string palsecreta;
        static string palmostrada;
        static int intentos = 8;

        public static void paraulaSecreta()
        {
            Console.WriteLine("Introduce la palabra secreta:");
            palsecreta = Console.ReadLine();
            for (int i = 0; i < palsecreta.Length; i++)
            {
                palmostrada += '*';
            }
        }

        public static void jugar()
        {
            string letra;
            string caracter;
            bool acierto=false;
            do
            {
                Console.WriteLine(palmostrada);
                Console.WriteLine("Introduce una letra:");
                letra = Console.ReadLine();

                for (int i = 0; i < palsecreta.Length; i++)
                {
                    caracter = palsecreta.Substring(i, 1);
                    if (caracter.Equals(letra))
                    {
                        palmostrada = palmostrada.Remove(i, 1);
                        palmostrada = palmostrada.Insert(i, letra);
                        acierto = true;
                    }
                }
                if (acierto)
                {
                    Console.WriteLine(palmostrada);
                }
                else
                {
                    intentos--;
                    pintarPenjat();
                }
                comprobarFinal();
            }

            while (!comprobarFinal());                
            }
        static bool comprobarFinal()
        {
            bool final = false;
            if (palmostrada==palsecreta)
            {
                Console.WriteLine("Has ganado");
                final=true;
            }
            if (intentos==0)
            {
                Console.WriteLine("Has perdido");
                final=true;
            }
            return final;
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
