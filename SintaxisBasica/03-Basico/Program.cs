namespace Gamalier3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("inserta primer numero");
            double primerNum = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Inserta segundo numero");
            Console.WriteLine("--------------------------------------------");
            double segundoNum = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Inserta tercer numero");
            double tercerNum = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");

            double suma, multiplicacion, division, resta;

            suma = primerNum + segundoNum;

            multiplicacion = primerNum * segundoNum;

            division = primerNum / segundoNum;

            resta = primerNum - segundoNum;

            Console.WriteLine("--------------------------------------------");

            Console.WriteLine($" Los resultados son Suma{suma} \n Resta{resta} \n Multiplicacion{multiplicacion} \n Division{division}");


            Console.WriteLine("--------------------------------------------");
        }
    }
}
