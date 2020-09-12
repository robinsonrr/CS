using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de variables

            int numero1 = 0;
            int numero2 = 0;
            int resultado = 0;
            int opcion = 0;
            string nombre, apellido;
            Boolean salir = false;
                                 
            
            Console.WriteLine("1- Presentar el nombre");
            Console.WriteLine("2- Operaciones matematicas");
            Console.WriteLine("3- Conversion dolares a pesos");
            Console.WriteLine("4- Celcius a Farengeit");
            Console.WriteLine("5- Promedio de calificaciones");
            Console.WriteLine("6- Convertir Millas a Kilometros");
            Console.WriteLine("7- Calcular Area del Triangulo");
            Console.WriteLine("--------------------------------");
            Console.Write("Digite la opcion deseada:");

            opcion = Convert.ToUInt16(Console.ReadLine());

            switch (opcion) {
                case 1:
                    // /.,,m m string nombre ="";
                    Console.WriteLine("Digite el Nombre:");
                    nombre = Console.ReadLine();
                    Console.WriteLine($"Bienvenido {nombre}");
                    break;
                case 2:
                    double a,b,resultado;
                    Console.WriteLine("Operaciones Matematicas");
                    break;
                 }

            Console.Write("Pulse una tecla...");
            Console.ReadKey();

            
        }
    }
}
