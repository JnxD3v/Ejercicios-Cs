using System.Diagnostics.CodeAnalysis;

namespace _28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int usarioNUm, resultado;
            resultado = 0;


            do
            {
                Console.Write("inserta el numero(cuando quiera terminar use 0): ");
                usarioNUm = int.Parse(Console.ReadLine());

                if (usarioNUm != 0)
                {
                    resultado = resultado + usarioNUm;
                }
            } while (usarioNUm != 0);

            Console.WriteLine("la sumatoria es igual a: " +  resultado);
        }
    }
}
