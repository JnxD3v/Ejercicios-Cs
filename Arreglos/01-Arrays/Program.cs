namespace _01_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numEntero = new int[10];
            int[] num2entero = new int[10];
            int[] resultados = new int[10];

            for (int i = 0; i < numEntero.Length; i++)
            {
                Console.Write("inserta el numero: ");
                numEntero[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");


            for (int j = 0; j < numEntero.Length; j++)
            {
                Console.Write("inserta el numero: ");
                num2entero[j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");


            int summaArry1 = numEntero.Sum();
            int sumaArray2 = num2entero.Sum();

            int[]sumador = {summaArry1 + sumaArray2};


        }
    }
}
