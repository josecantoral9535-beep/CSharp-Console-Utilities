using System;

namespace ReemplazoTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Reemplazador de Texto ---");

            Console.Write("Ingresa el texto completo: ");
            string textoOriginal = Console.ReadLine();

            Console.Write("Palabra a buscar: ");
            string buscar = Console.ReadLine();

            Console.Write("Palabra de reemplazo: ");
            string reemplazo = Console.ReadLine();

            // Realizamos el reemplazo
            string textoResultante = textoOriginal.Replace(buscar, reemplazo);

            Console.WriteLine("\n--- Resultado ---");
            Console.WriteLine(textoResultante);

            Console.ReadKey();
        }
    }
}