namespace gama14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;

            Console.WriteLine("DETERMINAR SI EL NUMERO ES POSITIVO O NEGATIVO");

            Console.Write("inserta el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("inserta el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("el primer numero es mayor");
            }

            else
            {
                Console.WriteLine("el segundo numero es mayor");
            }
        }
    }
}
