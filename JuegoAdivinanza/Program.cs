using System;

namespace JuegoAdivinanza
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101); // Genera entre 1 y 100
            int intentosMaximos = 3;
            int intentosRealizados = 0;
            bool haGanado = false;

            Console.WriteLine("==========================================");
            Console.WriteLine("¡Bienvenido a este juego de adivinar numeros!");
            Console.WriteLine("He pensado un número entre 1 y 100.");
            Console.WriteLine($"Tienes {intentosMaximos} intentos para adivinarlo.");
            Console.WriteLine("==========================================\n");

            // 2. Bucle de juego
            while (intentosRealizados < intentosMaximos)
            {
                intentosRealizados++;
                Console.Write($"Intento {intentosRealizados}/{intentosMaximos} - Ingresa tu número: ");

                if (!int.TryParse(Console.ReadLine(), out int suposicion))
                {
                    Console.WriteLine("Por favor, introduce un número válido.");
                    intentosRealizados--; // No penaliza un error de escritura
                    continue;
                }

                
                if (suposicion == numeroSecreto)
                {
                    haGanado = true;
                    break; // Sale del bucle inmediatamente
                }
                else if (suposicion < numeroSecreto)
                {
                    Console.WriteLine("-> El número secreto es MAYOR.");
                }
                else
                {
                    Console.WriteLine("-> El número secreto es MENOR.");
                }
            }

            // 4. Mensaje final
            Console.WriteLine("\n------------------------------------------");
            if (haGanado)
            {
                Console.WriteLine($"¡Felicidades! Adivinaste el {numeroSecreto} en {intentosRealizados} intentos.");
            }
            else
            {
                Console.WriteLine($"Se acabaron los intentos. El número era el {numeroSecreto}. ¡Suerte la próxima!");
            }
            Console.WriteLine("------------------------------------------");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
