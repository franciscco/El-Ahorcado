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

        //Método que pide una palabra secreta para desarrollar el juego
        public static void paraulaSecreta()
        {
            Console.Write("\n Introduce la palabra secreta: ");
            palsecreta = Console.ReadLine();
            for (int i = 0; i < palsecreta.Length; i++) //Bucle para rellenar con asteriscos la palabra mostrada
            {
                palmostrada += '*';
            }
        }

        //Método que ejecuta la dinámica del juego y llama a otros métodos
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
                comprobarFinal();                   //Ejecuta el método comprobar si el juego ha finalizado
                pintarPenjat();                     //Ejecuta el método que dibuja la figura del ahorcado
                Console.WriteLine();
                Console.Write("\n Introduce una letra: ");
                letra = Console.ReadLine();

                for (int i = 0; i < palsecreta.Length; i++)     //Bucle que comprueba la letra y la sustituye si se acierta
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

        //Método que comprueba si el juego ha acabado, bien porque se ha adivinado la palabra secreta,
        //o bien, porque se han agotado las vidas
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
        
        //Método que dibuja el gráfico del ahorcado en función del número de errores cometidos
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
