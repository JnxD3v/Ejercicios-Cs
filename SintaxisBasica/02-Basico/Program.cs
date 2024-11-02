namespace gamalier2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pagoHora, horaTrabajada, sueldoNeto, descuento;
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine(" " + " " + " " + " " + "¿Quieres saber cuanto gano tu empleado? \n " + "" + " "  +  " " +  " " + "Calculalo aqui");
            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine(" " + " " + " " + " " + "¿Cuanto gana tu empleado por hora trabajada?");
            Console.WriteLine("--------------------------------------------------------------");

            pagoHora = double.Parse(Console.ReadLine());



            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine(" " + " " + " " + " " + "¿Cuantas horas trabajo tu empleado?");
            Console.WriteLine("--------------------------------------------------------------");

            horaTrabajada = double.Parse(Console.ReadLine());

            descuento = 0.9409;

            sueldoNeto = pagoHora * horaTrabajada - descuento;

            Console.WriteLine(sueldoNeto);

           
        }
    }
}
