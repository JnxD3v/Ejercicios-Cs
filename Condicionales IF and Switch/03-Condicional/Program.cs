using System.Diagnostics.Tracing;

namespace gama10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("BIENVENIDO A DONDE SABES SI TE QUEMASTE O NO");
            int nota1, nota2, nota3, nota4, promedio;

            Console.Write("INSERTA LA PRIMERA NOTA: ");
            nota1 = int.Parse(Console.ReadLine());

            Console.Write("INSERTA LA SEGUNDA  NOTA: ");
            nota2 = int.Parse(Console.ReadLine());

            Console.Write("INSERTA LA TERCERA NOTA: ");
            nota3 = int.Parse(Console.ReadLine());

            Console.Write("INSERTA LA PRIMERA NOTA: ");
            nota4 = int.Parse(Console.ReadLine());

            promedio = (nota1 + nota2 + nota3 + nota4) / 4;
             
            if (promedio > 70) Console.WriteLine("Felicidades pasaste tu nota es: " + promedio);
            else if (promedio == 70) Console.WriteLine("pasaste a chepita tu nota es: " + promedio);
            else Console.WriteLine("ta quemao loco tu nota es: " + promedio);



        }
    }
}
