using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen
{
    internal class Program
    {
        static float num1, num2; //variables globales de la clase.
        static void Main(string[] args)
        {
            // variables globales y locales.
            int total;

            suma();
            resta();
            Console.Read();

        }

        static void suma() 
        {
            float resultado; // variable local       
            num1 = 3;
            num2 = 9;

            Console.WriteLine($"Suma: {num1 + num2}");
        
        }

        static void resta()
        {
            num1 = 1; num2 = 2;
            Console.WriteLine($"Resta: {num1 - num2}");

        }

    }
}
