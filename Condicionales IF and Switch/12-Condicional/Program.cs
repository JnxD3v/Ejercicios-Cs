namespace gama19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hijos, sueldoEmpleado, icentivo;

            Console.Write("INSERTA EL SUELDO DEL EMPLEADO");
            sueldoEmpleado = double.Parse(Console.ReadLine());


            Console.WriteLine("INSERTA TU CANTIDAD DE HIJOS");
            hijos = double.Parse(Console.ReadLine());


            if ( hijos > 0 )
            {
                Console.WriteLine("su sueldo sin el iincentivo es de" + " " + sueldoEmpleado);
                icentivo = hijos * 500;
                sueldoEmpleado = sueldoEmpleado + icentivo;
                Console.WriteLine("su sueldo + el incentivo es de" + " " + sueldoEmpleado);
                Console.WriteLine("el incentivo que le toco es de" + " " + icentivo);
            }
            else
            {
                Console.WriteLine("usted no tiene hijos por ende no le toca incentivo su sueldo sigue siendo de" + " " + sueldoEmpleado );
                 
            }


        }
    }
}
