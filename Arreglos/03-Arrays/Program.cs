namespace _03_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numerosEntero = new int[6];
            int par = 0;

            Console.WriteLine("Ingresa 6 números:");

            for (int i = 0; i < numerosEntero.Length; i++)
            {
                numerosEntero[i] = int.Parse(Console.ReadLine());
                if (numerosEntero[i] % 2 == 0)
                    par++;
                
            }

            Console.WriteLine($"Tienes {par} números pares");
        }
    }
}
