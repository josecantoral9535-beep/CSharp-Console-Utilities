using System;

class Tamagochi
{
    public string nombre;
    public int nivelHambre;
    public int nivelFelicidad = 100;
    public int nivelEnergia = 100;
    public int nivelSuciedad;

    // 3. PROPIEDAD: Indica si está enfermo basado en condiciones
    public bool EstaEnfermo => nivelSuciedad > 50 && nivelHambre > 50;

    // 2. CONSTRUCTOR: Personaliza el inicio según el modo de juego
    public Tamagochi(string nombreElegido, int hambre, int suciedad)
    {
        nombre = nombreElegido;
        nivelHambre = hambre;
        nivelSuciedad = suciedad;
    }

    // MÉTODO AUXILIAR: Mantiene los valores entre 0 y 100
    private void ValidarLimites()
    {
        if (nivelHambre < 0) nivelHambre = 0;
        if (nivelHambre > 100) nivelHambre = 100;
        if (nivelFelicidad < 0) nivelFelicidad = 0;
        if (nivelFelicidad > 100) nivelFelicidad = 100;
        if (nivelEnergia < 0) nivelEnergia = 0;
        if (nivelEnergia > 100) nivelEnergia = 100;
        if (nivelSuciedad < 0) nivelSuciedad = 0;
        if (nivelSuciedad > 100) nivelSuciedad = 100;
    }

    public void comer()
    {
        if (nivelHambre < 10) Console.WriteLine($"{nombre} no tiene hambre.");
        else if (nivelSuciedad > 50) Console.WriteLine($"{nombre} está muy sucio para comer.");
        else
        {
            nivelHambre -= 20;
            nivelSuciedad -= 5;
            Console.WriteLine($"{nombre} está comiendo...");
        }
        ValidarLimites();
    }

    public void jugar()
    {
        if (nivelEnergia < 30) Console.WriteLine($"{nombre} está muy cansado.");
        else if (nivelHambre > 60) Console.WriteLine($"{nombre} tiene mucha hambre.");
        else
        {
            nivelFelicidad += 20;
            nivelHambre += 10;
            nivelSuciedad += 15;
            Console.WriteLine($"¡Jugando con {nombre}!");
        }
        ValidarLimites();
    }

    public void dormir()
    {
        if (nivelHambre > 80) Console.WriteLine($"{nombre} tiene mucha hambre para dormir.");
        else
        {
            nivelEnergia = 100;
            nivelFelicidad += 10;
            nivelHambre += 20;
            Console.WriteLine($"{nombre} está durmiendo profundamente.");
        }
        ValidarLimites();
    }

    public void bañar()
    {
        nivelSuciedad = 0;
        nivelFelicidad -= 10;
        Console.WriteLine($"{nombre} ahora está limpio, pero un poco molesto por el agua.");
        ValidarLimites();
    }

    // 4. NUEVA OPCIÓN: Medicina
    public void darMedicina()
    {
        nivelFelicidad -= 20;
        nivelEnergia += 30;
        Console.WriteLine($"Le diste medicina a {nombre}. ¡Sabe feo pero le da fuerzas!");
        ValidarLimites();
    }

    public void pasarTiempo()
    {
        nivelHambre += 5;
        nivelFelicidad -= 5;
        nivelEnergia -= 5;
        ValidarLimites();
    }

    public void mostrarEstado()
    {
        // 5. CAMBIO DE COLOR SI ESTÁ ENFERMO
        if (EstaEnfermo)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"!!! AVISO: {nombre} ESTÁ ENFERMO !!!");
            Console.ResetColor();
        }

        Console.WriteLine($"--- Estado de {nombre} ---");
        Console.WriteLine($"Hambre:    {nivelHambre}/100");
        Console.WriteLine($"Felicidad: {nivelFelicidad}/100");
        Console.WriteLine($"Energía:   {nivelEnergia}/100");
        Console.WriteLine($"Suciedad:  {nivelSuciedad}/100");
    }
}

public class Program
{
    static void Main()
    {
        Console.WriteLine("--- BIENVENIDO A TAMAGOTCHI ---");
        Console.Write("Introduce el nombre de tu mascota: ");
        string nom = Console.ReadLine();

        // 3. SELECCIÓN DE DIFICULTAD
        Console.WriteLine("Elige dificultad: 1. Fácil | 2. Difícil");
        int dif = int.Parse(Console.ReadLine());

        Tamagochi mascota;
        if (dif == 2) mascota = new Tamagochi(nom, 50, 50); // Modo difícil
        else mascota = new Tamagochi(nom, 0, 0);           // Modo fácil

        int opcion;
        do
        {
            Console.WriteLine($"\n¿Qué quieres hacer con {mascota.nombre}?");
            Console.WriteLine($"1. Dar de comer a {mascota.nombre}");
            Console.WriteLine($"2. Jugar con {mascota.nombre}");
            Console.WriteLine($"3. Hacer dormir a {mascota.nombre}");
            Console.WriteLine($"4. Bañar a {mascota.nombre}");
            Console.WriteLine($"5. Dar medicina a {mascota.nombre}");
            Console.WriteLine("6. Ver estado de tu mascota ");
            Console.WriteLine("0. Salir");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: mascota.comer(); mascota.pasarTiempo(); break;
                case 2: mascota.jugar(); mascota.pasarTiempo(); break;
                case 3: mascota.dormir(); mascota.pasarTiempo(); break;
                case 4: mascota.bañar(); mascota.pasarTiempo(); break;
                case 5: mascota.darMedicina(); mascota.pasarTiempo(); break;
                case 6: mascota.mostrarEstado(); break;
            }

            if (mascota.nivelHambre >= 100) { Console.WriteLine("Murió de hambre..."); break; }
            if (mascota.nivelFelicidad <= 0) { Console.WriteLine("Escapó de tristeza..."); break; }

        } while (opcion != 0);
    }
}