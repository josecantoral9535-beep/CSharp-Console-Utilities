using System;

namespace ConversionTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Conversor de Temperatura ---");

            // 1. Aqui solicito al usuario la temperatura inicial
            Console.Write("Ingresa el valor numérico de la temperatura: ");
            double tempInicial = Convert.ToDouble(Console.ReadLine());

            // 2. La escala de origen
            Console.Write("Ingresa la escala inicial (C, F, K): ");
            char escalaOrigen = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            // 3. La de destino
            Console.Write("¿A qué escala deseas convertir (C, F, K)? ");
            char escalaDestino = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine("\n-------------------------------------");

            double resultado = 0;

            // Primero convierto todo a Celsius como "puente"
            double celsius = 0;

            switch (escalaOrigen)
            {
                case 'C': celsius = tempInicial; break;
                case 'F': celsius = (tempInicial - 32) * 5 / 9; break;
                case 'K': celsius = tempInicial - 273.15; break;
                default:
                    Console.WriteLine("Escala de origen no válida.");
                    return;
            }

            // Ahora convierto de Celsius a la escala de destino
            switch (escalaDestino)
            {
                case 'C': resultado = celsius; break;
                case 'F': resultado = (celsius * 9 / 5) + 32; break;
                case 'K': resultado = celsius + 273.15; break;
                default:
                    Console.WriteLine("Escala de destino no válida.");
                    return;
            }

            Console.WriteLine($"Resultado: {tempInicial}°{escalaOrigen} equivale a {resultado:F2}°{escalaDestino}");

            // Evitar que la consola se cierre sola 
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}