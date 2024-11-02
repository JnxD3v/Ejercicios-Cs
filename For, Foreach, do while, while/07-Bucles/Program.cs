namespace _27GAMALIER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresar, numtabla;

            Console.WriteLine("~inserta el numero de la tabla que desea");
            numeroIngresar = int.Parse(Console.ReadLine());

            Console.WriteLine("taba del numero ingresado: ");
            
            for (int i = 0; i <= 12; i++)
            {
                numtabla = numeroIngresar * i;
                Console.WriteLine($"{numeroIngresar} x {i} = {numtabla}");
            }
        }
    }
}
