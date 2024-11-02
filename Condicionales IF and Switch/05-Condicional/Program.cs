using System.Timers;

namespace gama12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;

            Console.WriteLine("DETERMINAR SI EL NUMERO ES POSITIVO O NEGATIVO");

            Console.Write("inserta el numero: ");
            numero1 = int.Parse(Console.ReadLine());


            if (numero1 > 0)
            {
                Console.WriteLine("el numero es positivo");
            }

            else if (numero1 < 0)
            {
                Console.WriteLine("el numero es negativo");
            }

            else
            {
                Console.WriteLine("El numero es 0");
            }
        }
    }
}
