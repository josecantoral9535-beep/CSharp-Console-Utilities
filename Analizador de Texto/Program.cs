using System;
using System.Collections.Generic;
using System.Linq;

namespace Analizador_de_texto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el texto que deseas analizar");
            string texto = Console.ReadLine();

            int totalCaracteres = texto.Length;

            int CaracteresSinEspacios = texto.Replace(" ", " ").Length;

            string[] palabras = texto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int totalpalabras = palabras.Length;

            Console.WriteLine("\n Resultados analisis");
            Console.WriteLine($"Caracteres totales: {totalCaracteres}");
            Console.WriteLine($"Cacracteres sin espacios: {CaracteresSinEspacios }");
            Console.WriteLine($"Total de palabras {totalpalabras}");

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
