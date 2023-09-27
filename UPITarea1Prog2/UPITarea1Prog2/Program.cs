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
                Console.WriteLine("----------------------------");
                Console.WriteLine("          TAREA 2");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1 - Ejercicio 1 - Camisas");
                Console.WriteLine("2 - Ejercicio 2 - Estudiante");
                Console.WriteLine("3 - Ejercicio 3 - Productos");
                Console.WriteLine("4 - Salir");
                Console.WriteLine("----------------------------");
                Console.Write("Digite una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: 
                        Console.Clear();    
                        Ejercicio1();
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2: 
                        Console.Clear();    
                        Ejercicio2();
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3: 
                        Console.Clear();    
                        Ejercicio3();
                        Console.WriteLine("Presione cualquier tecla para continuar...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    
                }

            } while (opcion != 4);
        }

        public static void Ejercicio1()  //camisas.
        {
            float precio = 0f;
            int cantidad = 0;   
            float total  = 0f;  

            Console.Write("Digite el precio de la camisa: ");
            precio = float.Parse(Console.ReadLine());
            Console.Write("Digite la cantidad: ");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            if (cantidad == 1) 
            { 
                Console.WriteLine($"Total a pagar por {cantidad} camisas es ${cantidad * precio}");
            }  
            
            else if (cantidad > 1 && cantidad < 6)
                {
                    total = (cantidad * precio) * 0.15f;
                    total = (cantidad * precio) - total;
                    Console.WriteLine($"Total a pagar por {cantidad} camisas es ${total} con descuento de 15%");
                } 
            
                else if (cantidad > 5)
                    {
                        total = (cantidad * precio) * 0.20f;
                        total = (cantidad * precio) - total;
                        Console.WriteLine($"Total a pagar por {cantidad} camisas es ${total} con descuento de 20%");
                    }

            Console.WriteLine(" ");
        }

        public static void Ejercicio2() // estudiante
        {

            Console.WriteLine("Ejercicio 2");

        }

        public static void Ejercicio3() // productos
        {
            int cantidad = 0;
            
            Console.Write("Digite la cantidad de productos: ");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            
            if ((cantidad > 1 && cantidad < 11))
            {
                Console.WriteLine($"Total a pagar por {cantidad} productos a $20 es: ${cantidad * 20}");
            }

            else if (cantidad > 10)
            {
                Console.WriteLine($"Total a pagar por {cantidad} productos a $15 es: ${cantidad * 15}");
            }
            
            Console.WriteLine(" ");

        }
    }
}
