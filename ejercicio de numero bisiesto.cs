using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese un año
        Console.Write("Ingrese un año: ");
        int año = int.Parse(Console.ReadLine());

        // Verificar si el año es bisiesto
        if (EsBisiesto(año))
        {
            Console.WriteLine($"{año} es un año bisiesto.");
        }
        else
        {
            Console.WriteLine($"{año} no es un año bisiesto.");
        }
    }

    // Función para determinar si un año es bisiesto
    static bool EsBisiesto(int año)
    {
        // Un año es bisiesto si es divisible entre 4, pero no entre 100, a menos que también sea divisible entre 400
        return (año % 4 == 0 && (año % 100 != 0 || año % 400 == 0));
    }
}
