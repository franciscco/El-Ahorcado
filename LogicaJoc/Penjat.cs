using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElPenjat
{
    //RAFAPUIG: Replanteate el diseño porque no se pueden hacer Console.WriteLine o Console.ReadLine en el modelo
    public class Penjat
    {
        static string palsecreta;
        static string palmostrada;
        static int intentos = 8;
        public static void paraulaSecreta()
        {
            Console.Write("\n Introduce la palabra secreta: ");
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
            do
            {
                bool acierto = false;
                
               
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(palmostrada);
                Console.WriteLine();
                comprobarFinal();
                pintarPenjat(); 
                Console.WriteLine();
                Console.Write("\n Introduce una letra: ");
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
                    if (intentos==0)
                    {
                        Console.Clear();
                        pintarPenjat();
                    }
                }
            }
            while (comprobarFinal() != true);
        }
        static bool comprobarFinal()
        {
            bool final = false;
            if (palmostrada == palsecreta)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\n ¡¡¡ H A S  G A N A D O !!!");
                final = true;
            }
            if (intentos == 0)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\n ¡Lo siento, has perdido!");
                final = true;
            }
            return final;
        }
        public static void pintarPenjat()
        {
            string penjat = "";
            switch (intentos)
            {
                case 0:
                    penjat = "___________\r\n" +
                           "|       |  \r\n" +
                           "|       o  \r\n" +
                           "|      /|\\\r\n" +
                           "|      / \\\r\n" +
                           "|          \r\n";
                    break;
                case 1:
                    penjat = "___________\r\n" +
                            "|       |  \r\n" +
                            "|       o  \r\n" +
                            "|      /|\\\r\n" +
                            "|      /  \r\n" +
                            "|          \r\n";
                    break;
                case 2:
                    penjat = "___________\r\n" +
                            "|       |  \r\n" +
                            "|       o  \r\n" +
                            "|      /|\\\r\n" +
                            "|          \r\n" +
                            "|          \r\n";
                    break;
                case 3:
                    penjat = "___________\r\n" +
                            "|       |  \r\n" +
                            "|       o  \r\n" +
                            "|      /|  \r\n" +
                            "|          \r\n" +
                            "|          \r\n";
                    break;
                case 4:
                    penjat = "___________\r\n" +
                            "|       |  \r\n" +
                            "|       o  \r\n" +
                            "|       |  \r\n" +
                            "|          \r\n" +
                            "|          \r\n";
                    break;
                case 5:
                    penjat = "___________\r\n" +
                            "|       |  \r\n" +
                            "|       o  \r\n" +
                            "|          \r\n" +
                            "|          \r\n" +
                            "|          \r\n";
                    break;
                case 6:
                    penjat = "___________\r\n" +
                            "|       |  \r\n" +
                            "|          \r\n" +
                            "|          \r\n" +
                            "|          \r\n" +
                            "|          \r\n";
                    break;
                case 7:
                    penjat = "___________\r\n" +
                           "|          \r\n" +
                           "|          \r\n" +
                           "|          \r\n" +
                           "|          \r\n" +
                           "|          \r\n";
                    break;
            }
            Console.WriteLine(penjat);
        }
    }
}
