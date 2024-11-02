namespace gama13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;

            Console.WriteLine("DETERMINAR SI EL NUMERO ES POSITIVO O NEGATIVO");

            Console.Write("inserta el numero: ");
            numero1 = int.Parse(Console.ReadLine());

            if (numero1 % 2 == 0)
            {
                Console.WriteLine("el numero es par");
            }

            else
            {
                Console.WriteLine("el numero es impar");
            }

            
        }
    }
    
}
