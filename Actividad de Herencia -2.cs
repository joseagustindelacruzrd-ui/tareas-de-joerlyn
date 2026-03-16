//Herencia en Programación Orientada a Objetos//
//Introducción//
//La herencia es uno de los pilares fundamentales de la Programación Orientada a Objetos (POO). Permite que una clase pueda heredar atributos y métodos de otra clase, promoviendo la reutilización del código y facilitando la organización de los programas.
//En este modelo, existe una clase base o clase padre, que contiene las características generales, y una clase derivada o clase hija, que hereda esas características y puede además agregar nuevas funcionalidades o modificar las existentes.
//La herencia permite representar relaciones del tipo “es un”. Por ejemplo, un perro es un animal, por lo tanto la clase Perro puede heredar de la clase Animal.//

using System;

namespace EjemplosHerencia
{

    // =========================
    // EJEMPLO 1
    // Vehiculo -> Carro
    // =========================
    class Vehiculo
    {
        public void Acelerar()
        {
            Console.WriteLine("El vehículo está acelerando.");
        }
    }

    class Carro : Vehiculo
    {
        public void EncenderRadio()
        {
            Console.WriteLine("La radio del carro está encendida.");
        }
    }


    // =========================
    // EJEMPLO 2
    // Animal -> Perro
    // =========================
    class Animal
    {
        public void Comer()
        {
            Console.WriteLine("El animal está comiendo.");
        }
    }

    class Perro : Animal
    {
        public void Ladrar()
        {
            Console.WriteLine("El perro está ladrando.");
        }
    }


    // =========================
    // EJEMPLO 3
    // Empleado -> Gerente
    // =========================
    class Empleado
    {
        public void Trabajar()
        {
            Console.WriteLine("El empleado está trabajando.");
        }
    }

    class Gerente : Empleado
    {
        public void Dirigir()
        {
            Console.WriteLine("El gerente dirige al equipo.");
        }
    }


    // =========================
    // EJEMPLO 4
    // Figura -> Circulo
    // =========================
    class Figura
    {
        public void Dibujar()
        {
            Console.WriteLine("Se está dibujando una figura.");
        }
    }

    class Circulo : Figura
    {
        public void CalcularArea()
        {
            Console.WriteLine("Calculando el área del círculo.");
        }
    }


    // =========================
    // EJEMPLO 5
    // Dispositivo -> Televisor
    // =========================
    class Dispositivo
    {
        public void Encender()
        {
            Console.WriteLine("El dispositivo se ha encendido.");
        }
    }

    class Televisor : Dispositivo
    {
        public void CambiarCanal()
        {
            Console.WriteLine("Canal cambiado en el televisor.");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione el ejemplo de herencia que desea ejecutar:");
            Console.WriteLine("1 - Vehiculo y Carro");
            Console.WriteLine("2 - Animal y Perro");
            Console.WriteLine("3 - Empleado y Gerente");
            Console.WriteLine("4 - Figura y Circulo");
            Console.WriteLine("5 - Dispositivo y Televisor");

            Console.Write("\nIngrese un número: ");
            string opcion = Console.ReadLine();

            Console.WriteLine();

            switch (opcion)
            {
                case "1":
                    Ejemplo1();
                    break;

                case "2":
                    Ejemplo2();
                    break;

                case "3":
                    Ejemplo3();
                    break;

                case "4":
                    Ejemplo4();
                    break;

                case "5":
                    Ejemplo5();
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static void Ejemplo1()
        {
            Carro carro = new Carro();
            carro.Acelerar();
            carro.EncenderRadio();
        }

        static void Ejemplo2()
        {
            Perro perro = new Perro();
            perro.Comer();
            perro.Ladrar();
        }

        static void Ejemplo3()
        {
            Gerente gerente = new Gerente();
            gerente.Trabajar();
            gerente.Dirigir();
        }

        static void Ejemplo4()
        {
            Circulo circulo = new Circulo();
            circulo.Dibujar();
            circulo.CalcularArea();
        }

        static void Ejemplo5()
        {
            Televisor tv = new Televisor();
            tv.Encender();
            tv.CambiarCanal();
        }
    }
}