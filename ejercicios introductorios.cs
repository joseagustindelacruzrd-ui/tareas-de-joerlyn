using System;

class Program
{
    static bool EsPrimo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i < n; i++)
            if (n % i == 0) return false;
        return true;
    }

    static void Main()
    {
        Console.WriteLine("===== MENU DE EJERCICIOS =====");
        Console.WriteLine("1. Suma de dígitos (2 cifras)");
        Console.WriteLine("2. Primo y negativo");
        Console.WriteLine("3. Ambos dígitos primos");
        Console.WriteLine("4. Suma par");
        Console.WriteLine("5. Mayor dígito (3 cifras)");
        Console.WriteLine("6. Dígito múltiplo de los otros");
        Console.WriteLine("7. Mayor de tres números");
        Console.WriteLine("8. Número capicúa (5 cifras)");
        Console.WriteLine("9. Segundo dígito igual al penúltimo");
        Console.WriteLine("10. Números entre dos valores");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());
        Console.WriteLine();

        switch (opcion)
        {
            case 1:
                Console.Write("Digite un número de dos dígitos: ");
                int num1 = Math.Abs(int.Parse(Console.ReadLine()));
                Console.WriteLine("Suma: " + (num1 / 10 + num1 % 10));
                break;

            case 2:
                Console.Write("Digite un número de dos dígitos: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("¿Es primo? " + EsPrimo(Math.Abs(num2)));
                Console.WriteLine("¿Es negativo? " + (num2 < 0));
                break;

            case 3:
                Console.Write("Digite un número de dos dígitos: ");
                int num3 = Math.Abs(int.Parse(Console.ReadLine()));
                int d1 = num3 / 10;
                int d2 = num3 % 10;
                Console.WriteLine("¿Ambos dígitos son primos? " + (EsPrimo(d1) && EsPrimo(d2)));
                break;

            case 4:
                Console.Write("Digite primer número: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Digite segundo número: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("¿La suma es par? " + ((a + b) % 2 == 0));
                break;

            case 5:
                Console.Write("Digite un número de tres dígitos: ");
                int num5 = Math.Abs(int.Parse(Console.ReadLine()));
                int c = num5 / 100;
                int d = (num5 / 10) % 10;
                int u = num5 % 10;

                int mayor = c;
                int pos = 1;

                if (d > mayor) { mayor = d; pos = 2; }
                if (u > mayor) { mayor = u; pos = 3; }

                Console.WriteLine("Mayor: " + mayor);
                Console.WriteLine("Posición: " + pos);
                break;

            case 6:
                Console.Write("Digite un número de tres dígitos: ");
                int num6 = Math.Abs(int.Parse(Console.ReadLine()));
                int x = num6 / 100;
                int y = (num6 / 10) % 10;
                int z = num6 % 10;

                bool condicion =
                    (x % y == 0 && x % z == 0) ||
                    (y % x == 0 && y % z == 0) ||
                    (z % x == 0 && z % y == 0);

                Console.WriteLine("¿Algún dígito es múltiplo de los otros? " + condicion);
                break;

            case 7:
                Console.Write("Digite primer número: ");
                int mayor7 = int.Parse(Console.ReadLine());

                Console.Write("Digite segundo número: ");
                int temp = int.Parse(Console.ReadLine());
                if (temp > mayor7) mayor7 = temp;

                Console.Write("Digite tercer número: ");
                temp = int.Parse(Console.ReadLine());
                if (temp > mayor7) mayor7 = temp;

                Console.WriteLine("El mayor es: " + mayor7);
                break;

            case 8:
                Console.Write("Digite un número de cinco dígitos: ");
                int num8 = Math.Abs(int.Parse(Console.ReadLine()));

                int a1 = num8 / 10000;
                int a2 = (num8 / 1000) % 10;
                int a4 = (num8 / 10) % 10;
                int a5 = num8 % 10;

                Console.WriteLine("¿Es capicúa? " + (a1 == a5 && a2 == a4));
                break;

            case 9:
                Console.Write("Digite un número de cuatro dígitos: ");
                int num9 = Math.Abs(int.Parse(Console.ReadLine()));

                int segundo = (num9 / 100) % 10;
                int penultimo = (num9 / 10) % 10;

                Console.WriteLine("¿Segundo dígito igual al penúltimo? " + (segundo == penultimo));
                break;

            case 10:
                Console.Write("Digite primer número: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite segundo número: ");
                int n2 = int.Parse(Console.ReadLine());

                int menor = Math.Min(n1, n2);
                int mayor10 = Math.Max(n1, n2);

                if (mayor10 - menor <= 10)
                {
                    for (int i = menor; i <= mayor10; i++)
                        Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("La diferencia es mayor que 10.");
                }
                break;

            default:
                Console.WriteLine("Opción inválida.");
                break;
        }

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}