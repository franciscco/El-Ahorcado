using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElPenjat;

namespace ElPenjat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n Introduce la palabra secreta: ");
            Penjat.secretWord();                    
            Console.Clear();
            string letra;
            do
            {
                bool acierto = false;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(Penjat.hideword);
                Console.WriteLine();

                Console.WriteLine(Penjat.showPenjat());

                Console.WriteLine();
                Console.Write("\n Introduce una letra: ");
                letra = Console.ReadLine();
                letra = letra.ToUpper();

                Penjat.caracter = Penjat.checkLetter(letra, ref acierto);

                if (acierto)
                {
                    Console.WriteLine(Penjat.hideword);
                }
                else
                {
                    Penjat.lifes--;
                    if (Penjat.lifes == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(Penjat.showPenjat());
                    }
                }
            }
            while (Penjat.checkFinal() != true);


            if (Penjat.lifes == 0)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\n ¡OOPS!");
                Console.WriteLine();
                Console.WriteLine("\n ¡HAS PERDIDO!");
                Console.WriteLine();
                Console.WriteLine("\n ¡INTÉNTALO DE NUEVO!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\n ¡¡¡ H A S  G A N A D O !!!");
                Console.WriteLine();
                Console.WriteLine("\n ¡¡¡ E N H O R A B U E N A !!!");
            }


            Console.ReadKey();
        }
    }
}
