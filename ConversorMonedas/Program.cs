using System;

namespace ConversorMonedas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tasas de cambio (Ejemplos fijos)
            const double USD = 0.059; // 1 Peso = 0.059 USD
            const double EUR = 0.054; // 1 Peso = 0.054 EUR
            const double JPY = 8.75;  // 1 Peso = 8.75 JPY

            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== CONVERSOR DE DIVISAS ===");
                Console.Write("Ingrese la cantidad en Pesos (MXN): ");

                if (!double.TryParse(Console.ReadLine(), out double pesos))
                {
                    Console.WriteLine("Cantidad no válida.");
                    Console.ReadKey();
                    continue;
                }

                Console.WriteLine("\nSeleccione la moneda de destino:");
                Console.WriteLine("1. Dólares (USD)");
                Console.WriteLine("2. Euros (EUR)");
                Console.WriteLine("3. Yenes (JPY)");
                Console.WriteLine("4. Salir");
                Console.Write("\nOpción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine($"\nResultado: {pesos * USD:F2} USD");
                        break;
                    case "2":
                        Console.WriteLine($"\nResultado: {pesos * EUR:F2} EUR");
                        break;
                    case "3":
                        Console.WriteLine($"\nResultado: {pesos * JPY:F2} JPY");
                        break;
                    case "4":
                        continuar = false;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPresione cualquier tecla para realizar otra conversión...");
                    Console.ReadKey();
                }
            }
        }
    }
};
