namespace gama5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cantidadProd, precioUnitarioProd, resultado;

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("¿Cuantos productos deseas comprar");
            cantidadProd = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");


            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("¿Cual es el precio unitario de ese producto que deseas comprar");
            precioUnitarioProd = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");

            resultado = cantidadProd * precioUnitarioProd;

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"el importe de este producto te saldra en  {resultado}");
            Console.WriteLine("--------------------------------------------");



        }
    }
}
