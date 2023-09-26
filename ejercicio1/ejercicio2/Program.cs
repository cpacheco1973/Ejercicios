using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //acumuladores y contadores
            int contador = 0;
            int total = 0;
            int salario = 0;
            //contadores
            contador = contador + 1;
            contador++;
            ++contador;
            contador--;
            --contador;

            //Acumuladores

            //salario 100
            //salario2 200
            //salario3 300
            total = total + salario;
            total += salario;
            total += 5;
            total *= 2;
            total /= 6;
            total -= 10;


            //sistema para calcular el promedio de n estudiantes
            //calcularr cuantos estudiantes tienen nota superior al promedio.
            String[] Estudiantes = new string[4];
            float[] notas = new float[4];
            float totalnotas = 0;

            for (int i = 0; i < Estudiantes.Length; i++)
            {
                Console.Write("Ingrese el nombre del Estudiante:");
                Estudiantes[i] = Console.ReadLine();
                Console.Write("Ingrese la nota del Estudiante:");
                notas[i] = float.Parse(Console.ReadLine());
                totalnotas = totalnotas + notas[i];

            }
            totalnotas /= Estudiantes.Length;
            Console.WriteLine($"El promedio de notas es: {totalnotas}");

            // calcular la cantidad de estudiantes con nota mayor al promedio.
            int notasmayores = 0;
            string nombre = "";
            int largo = 0;
            for (int i = 0; i < Estudiantes.Length; i++)
            {


                if (notas[i] > totalnotas)
                {
                    notasmayores++;
                    nombre = nombre + "," + Estudiantes[i];

                }

            }

            Console.WriteLine($"Hay {notasmayores} notas mayores al promedio {totalnotas}, y corresponde a los estudiantes {nombre}");
            Console.ReadLine();



        }
    }
}
