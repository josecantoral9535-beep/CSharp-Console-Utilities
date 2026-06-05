using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string password;
            Console.WriteLine("Escriba su contraseña:");
            password = Console.ReadLine();

            //lista para guardar qué requisitos no se cumplen
            List<string> faltantes = new List<string>();

            if (password.Length < 8)
                faltantes.Add("- Debe tener al menos 8 caracteres.");

            if (!password.Any(char.IsUpper))
                faltantes.Add("- Debe contener al menos una mayuscula.");

            if (!password.Any(char.IsLower))
                faltantes.Add("- Debe contener al menos una minuscula.");

            if (!password.Any(char.IsDigit))
                faltantes.Add("- Debe contener al menos un número.");

            
            if (faltantes.Count == 0)
            {
                Console.WriteLine("Tu contraseña es correcta y segura.");
            }
            else
            {
                Console.WriteLine("Tu contraseña es incorrecta. " + "\n Detalles:");
                foreach (string error in faltantes)
                {
                    Console.WriteLine(error);
                }
            }

            Console.WriteLine("\n Presione cualquier tecla para salir");
            Console.ReadKey();
            

        }
    }
}
