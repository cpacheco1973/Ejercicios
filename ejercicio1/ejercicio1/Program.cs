using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ejercicio1   // es un espacio de memoria en donde se contiene el programa que se crea.
{
    internal class Program
    {
        public struct empleado  // es como un vector, es una estructura que se puede usar como variable para cargar toda esa informacion de un empleado.
        {
            public int codigo;
            public string nombre;
            public float salario;
        }
        static void Main(string[] args)  // void es un método, 
        {

            /// tipos de datos
            int num1, num2;
            num1 = 30;
            float flotante = 3.14f; // la f se pone cuando hay decimales.
            double doble = 15.2d;  // la d se pone cuando hay decimales.
            decimal deci = 12.2m;  // la m se pone cuando hay decimales.
            byte b = 25; // variable de tipo entero.
            long largo = 15555555555; // número largo
            ulong ulargo = 56;
            short corto = 5660;
            Boolean boleano = false;
            char letra = 'a';
            string nombre1 = "Hoy el lunes 18 de septiembre";

            // var  define una variable variable.
            var variable = 20;  // se le puede pner cualquier tipo de dato, pero una vez inicializada debe mantener el tipo de dato.

            // dynamic 
            dynamic dinamica = 20; // acepta cualquier tipo de dato independiente del tipo que la inicializó
            dinamica = "Carlos";
            dinamica = true;
            dinamica = 12.2m;

            empleado emp;
            emp.codigo = 1;
            emp.nombre = "Carlos";
            emp.salario = 2000;

            // arreglos (tipo de dato compuesto)
            int n = 4;
            string[] musico = new string[n];

            musico[0] = "Carlos";
            musico[1] = "Maria";
            musico[2] = "Sofia";
            musico[3] = "Eva";

            float[] salario = new float[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite el salario:");
                salario[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine(musico[0]);
            Console.WriteLine(salario[0]);
            Console.WriteLine(musico[1]);
            Console.WriteLine(salario[1]);
            Console.WriteLine(musico[2]);
            Console.WriteLine(salario[2]);
            Console.WriteLine(musico[3]);
            Console.WriteLine(salario[3]);

            Console.ReadLine();

            string[] nombres = new string[] { "Ringo", "George", "Paul", "John" };



        }


    }
}