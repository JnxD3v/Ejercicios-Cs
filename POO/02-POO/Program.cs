using System.Timers;

namespace _02_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Articulo[] articulo = new Articulo[2];

            Console.WriteLine("inserta los articulos");

            for (int i = 0; i < articulo.Length; i++)
            {
                articulo[i] = new Articulo();
                Console.WriteLine("Articulo: "+ (i + 1));
                Console.Write("~Escribe el nombre del articulo: ");
                articulo[i].Nombre = Console.ReadLine();

                Console.Write("~Inserta el precio del articulo: ");
                articulo[i].precio = int.Parse(Console.ReadLine());

                Console.Write("~Inserta la categoria: ");
                articulo[i].Categoria = Console.ReadLine();

                Console.WriteLine();

            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("    Articulos ingresados    ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            for (int i = 0; i < articulo.Length; i++)
            {
                Console.WriteLine("Nombre: " + articulo[i].Nombre);
                Console.WriteLine("Precio: " + articulo[i].precio);
                Console.WriteLine("Nombre: " + articulo[i].Categoria);
                Console.WriteLine();
            }

            Console.WriteLine("Fin programa");
        }

        class Articulo
        {
            public string Nombre { get; set; }

            public int precio { get; set; }

            public string Categoria { get; set; }




        }
    }
}