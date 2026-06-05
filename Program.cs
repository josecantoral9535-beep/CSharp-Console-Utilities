using System;

namespace MayorMenorTresNumeros
{ 
    class Program
    {
        static void Main(string[] args) {

            double num1, num2, num3;
            Console.WriteLine("Determinar el numero mayor y menor entre 3 numeros");

            Console.WriteLine("Ingresa el primer numero");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo numero");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer numero");
            num3 = Convert.ToDouble(Console.ReadLine());

            double mayor = num1;
            if (num2 > mayor) mayor = num2;
            if (num3 > mayor) mayor = num3;

            double menor = num1;
            if (num2 < menor) menor = num2;
            if(num3 < menor) menor = num3;

            Console.WriteLine("------------------");
            Console.WriteLine($"El numero mayor es:{mayor}");
            Console.WriteLine($"El numero menor es {menor}");

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
















    }








}