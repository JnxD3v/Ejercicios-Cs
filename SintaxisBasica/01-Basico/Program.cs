namespace gamalier1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, suma, multiplicacion, resta, division;

            Console.Write("inserta el primer numero: ");
            num1 = double.Parse(Console.ReadLine());


            Console.Write("inserta el segundo numero: ");
            num2 = double.Parse(Console.ReadLine());


            suma = num1 + num2;

            resta = num1 - num2;

            multiplicacion = num1 * num2;

            division = num1 / num2;

            Console.WriteLine($"los resultados de las operaciones son \n Suma: {suma} \n Resta: {resta} \n Multiplicacion: {multiplicacion} \n Division: {division} ");


        }
    }
}
