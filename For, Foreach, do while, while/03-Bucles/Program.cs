using System.Timers;

namespace _23GAMALIER
{
    internal class Program
    {
//        Crear un programa que lea n cantidad de números enteros, si la sumatoria es mayor
//o igual a 100, el programa debe mostrar un mensaje indicando que la sumatoria es
//mayor o igual a 100.

        static void Main(string[] args)
        {
            int numero;
           

            Console.Write("Inserta el numero: ");
            numero = int.Parse(Console.ReadLine());
            
             
           while(numero <= 100)
            {
                Console.WriteLine("Inserta otro numero");
                numero = int.Parse(Console.ReadLine());

                numero = numero + numero;

                
            }

            Console.WriteLine("el programa ah terminado");
                    
        }
    }
}
