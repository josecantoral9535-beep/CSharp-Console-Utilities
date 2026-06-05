using System;

namespace EvaluacionCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su edad");
            int edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su salario");
            double salario = double.Parse(Console.ReadLine());

            if (edad >= 18 && salario >= 2000)
            {

                Console.WriteLine("Tu credito ha sido aprobado");


            }

            else
            {

                Console.WriteLine("Lo sentimos, no cumples los requisitos, tu credito no fue aprobado");

            }

            Console.WriteLine("\n Presione cualquier tecla para salir");
            Console.ReadKey();

        }

    }
}