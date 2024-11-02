namespace _25GAMALIER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero, promedio;
            numero = 0;

            for (int i = 0; i < 100; i++) numero++;

            numero = (numero * (numero + 1)) / 2;

            promedio = numero / 100;

            Console.WriteLine($"el resultado del promedio es: {promedio}");
        }
    }
}
