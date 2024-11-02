namespace gama16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3, medio, mayor, bajo;

            Console.WriteLine("DETERMINAR SI EL NUMERO ES POSITIVO O NEGATIVO");

            Console.Write("inserta el primer numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("inserta el segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());


            Console.Write("inserta el tercer numero: ");
            numero3 = int.Parse(Console.ReadLine());

            if (numero1 > numero2 & numero1 > numero3)
            {
                mayor = numero1;
                if (numero2 > numero3)
                {
                    medio = numero2;
                    bajo = numero3;
                }

                else
                {
                    medio = numero2;
                    bajo = numero3;
                }

            }
            else if (numero2 > numero3)
            {
                mayor = numero2;

                if (numero1> numero3)
                {
                    medio = numero1;
                    bajo = numero3;
                }

                else
                {
                    medio = numero3;
                    bajo = numero1;
                }

            }
            else
            {
                mayor = numero3;

                if (numero1 > numero2)
                {
                    medio = numero1;
                    bajo = numero2;
                }

                else
                {
                    medio = numero2;
                    bajo = numero1;
                }

               

            }

            Console.WriteLine($"el numero mayor es {mayor}");
            Console.WriteLine($"el numero del medio es {medio}");
            Console.WriteLine($"el numero mas bajo es {bajo}");
        }
    }
}
