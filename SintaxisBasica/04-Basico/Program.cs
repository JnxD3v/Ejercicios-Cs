namespace gama4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("         inserta primer numero              ");
            double primerNum = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("         Inserta segundo numero             ");
            Console.WriteLine("--------------------------------------------");
            double segundoNum = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("               Inserta tercer numero         ");
            double tercerNum = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("               Inserta cuarto numero          ");
            double cuartoNum = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");


            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Inserta quinto numero");
            double quintoNum = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------------------");

            double resultado = primerNum + segundoNum + tercerNum + cuartoNum + quintoNum;

            double promedio = resultado / 5;

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" " + " " +  "el promedio es :" + " " + promedio);
            Console.WriteLine("--------------------------------------------");




        }
    }
}
