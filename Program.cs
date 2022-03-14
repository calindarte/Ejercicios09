using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una frase");
            string cadena = Console.ReadLine();

            string cadenaMayusculas = cadena.ToUpper();

            
            Console.WriteLine(cadenaMayusculas);
            Console.ReadLine(); 
        }
    }
}
