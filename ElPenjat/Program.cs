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
            Penjat.paraulaSecreta();
            Console.Clear();
            Penjat.jugar();
            Console.ReadKey();            
        }      
    }
}
