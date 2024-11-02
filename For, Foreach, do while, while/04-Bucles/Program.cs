namespace GAMALIER24
{
    //Calcular la suma de los primeros 100 numeros naturales.

    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int resultado;

            for (int i = 0; i < 100; i++) numero++;

            resultado = (numero * (numero + 1)) / 2;
            Console.WriteLine($"el resultado de la suma de los 100 numeros es: {resultado}");
        }
    }
}
