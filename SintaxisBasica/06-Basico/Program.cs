using System.Timers;

namespace gamalier6
{
    //Crear un programa que calcule la cantidad y precio de un artículo, luego calcular
    //l impuesto de ITBIS que es el 18%, aplicar un descuento de 10%, y calcular el total
    //general.El ITBIS se calcula multiplicando el importe por el 18%, el descuento se calcula
    //multiplicando el importe por el 10% y el total general se calcula restando el importe
    //menos descuento más ITBIS.


    internal class Program
    {
        static void Main(string[] args)
        {
            double cantidad, precio, impuestoiTBiS, descuento, total, importe;


            
            Console.Write("inserta la cantidad:");
            cantidad = double.Parse(Console.ReadLine());


            Console.Write("inserta el precio:");
            precio = double.Parse(Console.ReadLine());

            importe = precio * cantidad;
            
            impuestoiTBiS = importe * 0.18;

            descuento = importe * 0.10;

            total = (importe - descuento) + impuestoiTBiS;

            Console.WriteLine($"el total a pagar es: {total}");

            





        }
    }
}
