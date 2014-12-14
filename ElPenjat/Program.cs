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
                bool succes = false;
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(Penjat.hideword);         //muestra la palabra con asteriscos
                Console.WriteLine();

                Console.WriteLine(Penjat.showPenjat());     //dibuja el ahorcado

                Console.WriteLine();
                Console.Write("\n Introduce una letra: ");
                letra = Console.ReadLine();
                letra = letra.ToUpper();                    //convierte la letra introducida a mayúsculas

                Penjat.caracter = Penjat.checkLetter(letra, ref succes);  //Comprueba la letra introducida

                if (succes)
                {
                    Console.WriteLine(Penjat.hideword);     //Si se acierta una letra la sustituye en pantalla
                }
                else
                {
                    Penjat.lifes--;
                    if (Penjat.lifes == 0)
                    {
                        Console.Clear();
                        Console.WriteLine(Penjat.showPenjat()); //En caso contrario resta vidas y añade un trazo al ahorcado
                    }
                }
            }
            while (Penjat.checkFinal() != true); //Se repite el bucle do mientras no se agoten lasvidas o se adivine la palabra


            if (Penjat.lifes == 0)                      //Si se acaban las vidas
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\n ¡OOPS!");
                Console.WriteLine();
                Console.WriteLine("\n ¡HAS PERDIDO!");
                Console.WriteLine();
                Console.WriteLine("\n ¡INTÉNTALO DE NUEVO!");
            }
            else                                    //Si se adivina la palabra secreta
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
