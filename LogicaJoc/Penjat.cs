using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElPenjat
{
    public class Penjat
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
            bool acierto = false;
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
                Console.Clear();
                comprobarFinal();
            }
            while (comprobarFinal() != true);
        }
        static bool comprobarFinal()
        {
            bool final = false;
            if (palmostrada == palsecreta)
            {
                Console.WriteLine("Has ganado");
                final = true;
            }
            if (intentos == 0)
            {
                Console.WriteLine("Has perdido");
                final = true;
            }
            return final;
        }
        public static void pintarPenjat()
        {
            string penjat = "";
            switch (intentos)
            {
                case '0':
                    penjat = "___________\r\n" +
                           "|       |  \r\n" +
                           "|       o  \r\n" +
                           "|      /|\\\r\n" +
                           "|      / \\\r\n" +
                           "|          \r\n";       
                    break;
                case '1':
                    penjat = "___________\r\n" +
                            "|       |  \r\n" +
                            "|       o  \r\n" +
                            "|      /|\\\r\n" +
                            "|      /  \r\n" +
                            "|          \r\n";
                    break;
                case '2':
                    penjat = "___________\r\n" +
                            "|       |  \r\n" +
                            "|       o  \r\n" +
                            "|      /|\\\r\n" +
                            "|          \r\n" +
                            "|          \r\n";
                    break;
                case '3':
                    penjat = "___________\r\n" +
                            "|       |  \r\n" +
                            "|       o  \r\n" +
                            "|      /|  \r\n" +
                            "|          \r\n" +
                            "|          \r\n";
                    break;
                case '4':
                    penjat = "___________\r\n" +
                            "|       |  \r\n" +
                            "|       o  \r\n" +
                            "|       |  \r\n" +
                            "|          \r\n" +
                            "|          \r\n";
                    break;
                case '5': penjat = "___________\r\n" +
                            "|       |  \r\n" +
                            "|       o  \r\n" +
                            "|          \r\n" +
                            "|          \r\n" +
                            "|          \r\n";
                    break;
                case '6':
                    penjat = "___________\r\n" +
                            "|       |  \r\n" +
                            "|          \r\n" +
                            "|          \r\n" +
                            "|          \r\n" +
                            "|          \r\n";
                    break;
                case '7':
                    penjat = "___________\r\n" +
                           "|          \r\n" +
                           "|          \r\n" +
                           "|          \r\n" +
                           "|          \r\n" +
                           "|          \r\n";
                    break;
            }
            Console.WriteLine(penjat);
            Console.ReadKey();
        }
    }
}
