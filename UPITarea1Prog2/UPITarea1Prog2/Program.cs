using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
            string nombre = "";
            string carnet = "";
            float[] quiz = new float[3];
            float[] tarea = new float[3];
            float[] examen = new float[3];
            float totalquiz = 0f;
            float totaltarea = 0f;
            float totalexamen = 0f;
            float promquiz = 0f;
            float promtarea = 0f;
            float promexamen = 0f;
            float porcquiz = 0f;
            float porctarea = 0f;
            float porcexamen = 0f;
            float notaporc = 0f;
            string condicion = "";
            int contador;

            float f = 13.5f;
            string s = f.ToString("R");
            Console.WriteLine(s);

            Console.Write("Ingrese el carnet del Estudiante: ");
            carnet = Console.ReadLine();
            Console.Write("Ingrese el nombre del Estudiante: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Notas de Quiz");
            contador = 0;
            for (int i = 0; i < quiz.Length; i++)
            {
                contador++;
                Console.Write("Ingrese la nota del Quiz_"+contador+"/3 del estudiante:");
                quiz[i] = float.Parse(Console.ReadLine());
                totalquiz = totalquiz + quiz[i];
                
            }

            Console.WriteLine("Notas de Tareas");
            contador = 0;
            for (int i = 0; i < tarea.Length; i++)
            {
                contador++;
                Console.Write("Ingrese la nota de la Tarea_"+contador+"/3 del estudiante:");
                tarea[i] = float.Parse(Console.ReadLine());
                totaltarea = totaltarea + tarea[i];
            }

            Console.WriteLine("Notas de Examen");
            contador = 0;
            for (int i = 0; i < examen.Length; i++)
            {
                contador++;
                Console.Write("Ingrese la nota del Examen_"+contador+"/3 del estudiante:");
                examen[i] = float.Parse(Console.ReadLine());
                totalexamen = totalexamen + examen[i];
            }

            promquiz = totalquiz / quiz.Length;
            promtarea = totaltarea / tarea.Length;
            promexamen = totalexamen / examen.Length;
            

            porcquiz = (promquiz / 100) * 25;
            porctarea = (promtarea / 100) * 30;
            porcexamen = (promexamen / 100 * 45);
            notaporc = porcquiz + porctarea + porcexamen;

            if ((notaporc > 0 && notaporc < 50))
            {
                condicion = "REPROBADO";
            }

            else if ((notaporc >= 50 && notaporc < 70))
            {
                condicion = "APLAZADO";
            }

            else if ((notaporc >= 70))
            {
                condicion = "APROBADO";
            }

            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("Resumen Notas");
            Console.WriteLine($"Estudiante: {carnet} - {nombre}");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("           Nota 1        Nota 2        Nota 3       Promedio    Porcentaje");
            Console.WriteLine($"Quiz       {((quiz[0]).ToString("N2")).PadLeft(6)}        {((quiz[1]).ToString("N2")).PadLeft(6)}        {((quiz[2]).ToString("N2")).PadLeft(6)}         {((promquiz).ToString("N2")).PadLeft(6)}        {((porcquiz).ToString("N2")).PadLeft(6)}");
            Console.WriteLine($"Tareas     {((tarea[0]).ToString("N2")).PadLeft(6)}        {((tarea[1]).ToString("N2")).PadLeft(6)}        {((tarea[2]).ToString("N2")).PadLeft(6)}         {((promtarea).ToString("N2")).PadLeft(6)}        {((porctarea).ToString("N2")).PadLeft(6)}");
            Console.WriteLine($"Examen     {((examen[0]).ToString("N2")).PadLeft(6)}        {((examen[1]).ToString("N2")).PadLeft(6)}        {((examen[2]).ToString("N2")).PadLeft(6)}         {((promexamen).ToString("N2")).PadLeft(6)}        {((porcexamen).ToString("N2")).PadLeft(6)}");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine($"CONDICION: {condicion}                                                 {((notaporc).ToString("N2")).PadLeft(6)}");
            Console.WriteLine("--------------------------------------------------------------------------------");

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
