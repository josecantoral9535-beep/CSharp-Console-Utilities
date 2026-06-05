    using System;

    namespace OperadoresAsignacion
    {

        class Program
        {

            static void Main(String[] args)
            {
                Console.WriteLine("Ingresa un numero entero");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\n Numero inicial:{numero}");

                numero += 10;
                Console.WriteLine($"Despues de sumar 10 = {numero}");

                numero -= 5;
                Console.WriteLine($"Despues de restar 5 = {numero}");

                numero *= 2;
                Console.WriteLine($"Despues de multiplicar por 2 es = {numero}");

                numero /= 3;
                Console.WriteLine($"Despues de dividir por 3 es = {numero}");

                numero %= 4;
                Console.WriteLine($"Despues de obtener el modulo 4 = {numero}");


                Console.WriteLine("Presione cualquier tecla para salir");
                Console.ReadKey();


            }
        }
    }