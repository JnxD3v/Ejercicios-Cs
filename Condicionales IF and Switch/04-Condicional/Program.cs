namespace gama11
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

            if (promedio > 90 & promedio <=100)
            {
                Console.WriteLine("felicicidades en este año te fue exelente y tu nota fue de " + promedio);
            }

            else if (promedio < 90 & promedio > 80 )
            {
                Console.WriteLine("felicicidades en este año fue bueno para ti  y tu nota fue de " + promedio);
            }

            else if(promedio <80 & promedio > 75)
            {
                Console.WriteLine("felicicidades en este año  fue bueno y tu nota fue de " + promedio);
            }

            else if (promedio >70 & promedio < 74)
            {
                Console.WriteLine("felicicidades en este año  fue regular y tu nota fue de " + promedio);
            }

            else
            {

                Console.WriteLine("Malas noticias en este año te fue muy defisiente y tu nota fue de " + promedio);
            }
        }
    }
}
