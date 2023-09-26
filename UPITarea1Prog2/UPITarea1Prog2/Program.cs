using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPITarea1Prog2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1 - Ejercicio 1 - Camisas");
                Console.WriteLine("2 - Ejercicio 2");
                Console.WriteLine("3 - Ejercicio 3");
                Console.WriteLine("4 - Ejercicio 4");
                Console.WriteLine("Digite una opcion");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: 
                        Console.Clear();    
                        Ejercicio1();
                        break;
                    case 2: 
                        Console.Clear();    
                        Ejercicio2();
                        break;  
                    case 3: 
                        Console.Clear();    
                        Ejercicio3();
                        break;
                    default:
                        break;
                }

            } while (opcion != 4);
        }

        public static void Ejercicio1()  //camisas.
        {
            float precio = 0f;
            int cantidad = 0;   
            float total  = 0f;  

            Console.WriteLine("Digite el precio de la camisa: ");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la cantidad: ");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad == 1) 
            { 
                Console.WriteLine($"Total a pagar por {cantidad} camisas es: {cantidad * precio}");
            }  
            
            else if (cantidad > 1 && cantidad < 6)
                {
                    total = (cantidad * precio) * 0.15f;
                    total = (cantidad * precio) - total;
                    Console.WriteLine($"Total a pagar por {cantidad} camisas es: {total} con descuento de 15%");
                } 
            
                else if (cantidad > 5)
                    {
                        total = (cantidad * precio) * 0.20f;
                        total = (cantidad * precio) - total;
                        Console.WriteLine($"Total a pagar por {cantidad} camisas es: {total} con descuento de 20%");
                    }        
        
        }

        public static void Ejercicio2()
        {

            Console.WriteLine("Ejercicio 2");

        }

        public static void Ejercicio3()
        {

            Console.WriteLine("Ejercicio 3");

        }
    }
}
