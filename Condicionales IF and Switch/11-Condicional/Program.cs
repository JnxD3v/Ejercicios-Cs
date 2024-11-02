namespace gama18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prodlunes, prodMartes, prodMiercoles, prodJueves, prodViernes, prodTotal;

            Console.Write("INSERTA PRODUCCION DEL LUNES: ");
            prodlunes = int.Parse(Console.ReadLine());

            Console.Write("INSERTA PRODUCCION DEL MARTES: ");
            prodMartes = int.Parse(Console.ReadLine());

            Console.Write("INSERTA PRODUCCION DEL MIERCOLES: ");
            prodMiercoles = int.Parse(Console.ReadLine());

            Console.Write("INSERTA PRODUCCION DEL JUEVES: ");
            prodJueves = int.Parse(Console.ReadLine());

            Console.Write("INSERTA PRODUCCION DEL VIERNES: ");
             prodViernes = int.Parse(Console.ReadLine());

            prodTotal = (prodlunes + prodMartes + prodMiercoles + prodJueves + prodViernes);

            if ( prodTotal >= 20000)
            {
                Console.WriteLine("Aplica para el incentivo");
            }

            else
            {
                Console.WriteLine("no aplica para el insentivo");
            }



        }
    }
}
