using System;

namespace GAMALIER9
{
//    2. Crear un programa que introduzca el precio de un articulo y aplique un descuento con la siguiente escala:

//Escala Porcentaje
//de 1,000 a 5,000                       3%
//de 5,001 a 10,000                      5%
//de 10,001 a 15,000                     8%
//de 15,001 a 20,000                     10%
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("~BIENVENIDO A TU CALCULADORA DE DESCUESTOS FAVORITOS~");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.Write("INSERTA EL PRECIO DE TU ARTICULO: ");
            double precioOriginal = double.Parse(Console.ReadLine());
            double precio=0;

            if (precioOriginal >= 1000 || precioOriginal >= 5000) 
            {
                precio =  (precioOriginal * 3) / 100;
                precio = precioOriginal - precio;
                Console.WriteLine($"el descuento que se aplicara es de 3%, y el precio ahora es de: {precio}");
            }

            else if (precioOriginal >= 5.001 || precioOriginal >= 10000)
            { 
                precio =  (precioOriginal * 5) / 100;
                precio = precioOriginal - precio;

                Console.WriteLine($"el descuento que se aplicara es de 5%, y el precio ahora es de: {precio}");
            }

            else if (precioOriginal >= 10001 || precio >= 15000)
            {
                precio = (precioOriginal * 8) / 100;
                precio = precioOriginal - precio;
                Console.WriteLine($"el descuento que se aplicara es de 8%, y el precio ahora es de: {precio}");
            }

            else if (precioOriginal >= 15001 || precioOriginal >= 20000)
            {
                precio = (precioOriginal * 10) /100;
                precio = precioOriginal - precio;
                Console.WriteLine($"el descuento que se aplicara es de 3%, y el precio ahora es de: {precio}"); Console.WriteLine($"el descuento que se aplicara es de 10%, y el precio ahora es de: {precio}");
            }

            else
            {
                Console.WriteLine("A ocurrido un error inesperado");
            }




        }
    }
}
