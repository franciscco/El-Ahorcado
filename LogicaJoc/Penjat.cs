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
        static string word;
        public static string hideword;
        public static string caracter = "";
        public static int lifes = 8;
        

        //Método que pide una palabra secreta para desarrollar el juego
        public static string secretWord()
        {            
            word = Console.ReadLine();
            word = word.ToUpper();          //La pasamos a mayúsculas para que siempre reconozca la letra
            for (int i = 0; i < word.Length; i++) //Bucle para rellenar con asteriscos la palabra mostrada
            {
                hideword += '*';
            }
            return hideword;
        }        
     
        //Método que comprueba si la letra introducida por el jugador es correcta
        public static string checkLetter(string letter, ref bool acierto)
        {
            for (int i = 0; i < word.Length; i++)     
            {
                caracter = word.Substring(i, 1);
                if (caracter.Equals(letter))
                {
                    hideword = hideword.Remove(i, 1);
                    hideword = hideword.Insert(i, letter);
                    acierto = true;
                }
            }
            return caracter;
        }

        //Método que comprueba si el juego ha acabado, bien porque se ha adivinado la palabra secreta,
        //o bien, porque se han agotado las vidas
        public static bool checkFinal()
        {
            bool final = false;
            if (hideword == word)
            {               
                final = true;
            }
            if (lifes == 0)
            {                
                final = true;
            }
            return final;
        }
        
        //Método que dibuja el gráfico del ahorcado en función del número de errores cometidos
        public static string showPenjat()
        {
            string penjat = "";
            switch (lifes)
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
            return penjat;
        }
    }
}
