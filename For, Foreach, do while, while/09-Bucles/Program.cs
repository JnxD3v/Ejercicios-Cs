using System;
namespace _29GAMALIER
{

    class Program
    {
        static void Main()
        {
            Console.Write("cuantas filas tendra el patron: ");
            int filas =  int.Parse(Console.ReadLine()); 

            for (int i = 1; i <= filas; i++)
            {
                for (int j = 1; j <= i; j++)
                { 
                    Console.Write("*");
                }
                Console.WriteLine(); 
            }
        }
    }

}
