using System;

class Program
{
    static bool EsPrimo(int n)
    {
        n = Math.Abs(n);
        if (n < 2) return false;
        for (int i = 2; i < n; i++)
            if (n % i == 0)
                return false;
        return true;
    }

    static void Main()
    {
        int[] numeros = new int[10];

        Console.WriteLine("Digite 10 números enteros:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Posición " + i + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n===== MENU =====");
        Console.WriteLine("1. Mayor número y posición");
        Console.WriteLine("2. Mayor número par y posición");
        Console.WriteLine("3. Mayor número primo y posición");
        Console.WriteLine("4. Promedio entero");
        Console.WriteLine("5. Cantidad de números negativos");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (opcion)
        {
            case 1:
                int mayor = numeros[0];
                int posMayor = 0;

                for (int i = 1; i < 10; i++)
                {
                    if (numeros[i] > mayor)
                    {
                        mayor = numeros[i];
                        posMayor = i;
                    }
                }

                Console.WriteLine("Mayor número: " + mayor);
                Console.WriteLine("Posición: " + posMayor);
                break;

            case 2:
                int mayorPar = int.MinValue;
                int posPar = -1;

                for (int i = 0; i < 10; i++)
                {
                    if (numeros[i] % 2 == 0 && numeros[i] > mayorPar)
                    {
                        mayorPar = numeros[i];
                        posPar = i;
                    }
                }

                if (posPar != -1)
                {
                    Console.WriteLine("Mayor número par: " + mayorPar);
                    Console.WriteLine("Posición: " + posPar);
                }
                else
                {
                    Console.WriteLine("No hay números pares.");
                }
                break;

            case 3:
                int mayorPrimo = int.MinValue;
                int posPrimo = -1;

                for (int i = 0; i < 10; i++)
                {
                    if (EsPrimo(numeros[i]) && numeros[i] > mayorPrimo)
                    {
                        mayorPrimo = numeros[i];
                        posPrimo = i;
                    }
                }

                if (posPrimo != -1)
                {
                    Console.WriteLine("Mayor número primo: " + mayorPrimo);
                    Console.WriteLine("Posición: " + posPrimo);
                }
                else
                {
                    Console.WriteLine("No hay números primos.");
                }
                break;

            case 4:
                int suma = 0;

                for (int i = 0; i < 10; i++)
                    suma += numeros[i];

                int promedio = suma / 10;

                Console.WriteLine("Promedio entero: " + promedio);
                break;

            case 5:
                int negativos = 0;

                for (int i = 0; i < 10; i++)
                {
                    if (numeros[i] < 0)
                        negativos++;
                }

                Console.WriteLine("Cantidad de números negativos: " + negativos);
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}