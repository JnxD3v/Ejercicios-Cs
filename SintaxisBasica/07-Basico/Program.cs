namespace gamalier7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sueldo, nuevoSueldo, aumento;


            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("       ~Inserta el sueldo de tu empleado~     ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            sueldo = double.Parse(Console.ReadLine());

            aumento = 0.15;
            nuevoSueldo = (sueldo * aumento) +sueldo;


             Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
             Console.WriteLine($"El nuevo sueldo es de {nuevoSueldo} pesos");
             Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");



        }
    }
}
