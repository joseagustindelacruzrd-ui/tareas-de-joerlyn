using System;

namespace ProyectoAves
{
    // Clase principal
    class Ave
    {
        public string Nombre;
        public int Edad;

        public Ave(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // Métodos que podrán cambiar en las clases hijas
        public virtual void Volar()
        {
            Console.WriteLine(Nombre + " está volando.");
        }

        public virtual void HacerSonido()
        {
            Console.WriteLine(Nombre + " hace un sonido.");
        }
    }

    // Clase derivada 1
    class Aguila : Ave
    {
        public Aguila(string nombre, int edad) : base(nombre, edad) { }

        public override void Volar()
        {
            Console.WriteLine(Nombre + " vuela muy alto en el cielo.");
        }

        public override void HacerSonido()
        {
            Console.WriteLine(Nombre + " hace un sonido fuerte.");
        }
    }

    // Clase derivada 2
    class Pato : Ave
    {
        public Pato(string nombre, int edad) : base(nombre, edad) { }

        public override void Volar()
        {
            Console.WriteLine(Nombre + " vuela pero no muy alto.");
        }

        public override void HacerSonido()
        {
            Console.WriteLine(Nombre + " hace cuac cuac.");
        }
    }

    // Clase derivada 3
    class Gallina : Ave
    {
        public Gallina(string nombre, int edad) : base(nombre, edad) { }

        public override void Volar()
        {
            Console.WriteLine(Nombre + " casi no puede volar.");
        }

        public override void HacerSonido()
        {
            Console.WriteLine(Nombre + " hace cocorocó.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ave ave1 = new Aguila("Aguila real", 5);
            Ave ave2 = new Pato("Pato criollo", 2);
            Ave ave3 = new Gallina("Gallina blanca", 3);

            ave1.Volar();
            ave1.HacerSonido();

            Console.WriteLine();

            ave2.Volar();
            ave2.HacerSonido();

            Console.WriteLine();

            ave3.Volar();
            ave3.HacerSonido();
        }
    }
}