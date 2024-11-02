using System.Drawing;
using System.Timers;

namespace ClasesYObjetosPerlaxd
{
     class Program
    {
        static void Main(string[] args)
        {
           Dispositivo dispositivo1 = new Dispositivo();

            Console.Write(" ~inserta el tipo de dispositivo: ");
            dispositivo1.tipo = (Console.ReadLine());

            Console.Write(" ~inserta la marca del dispositivo: ");
            dispositivo1.marca = (Console.ReadLine());


            Console.Write("~inserta el color");
            dispositivo1.color=  (Console.ReadLine());

            Console.WriteLine($"el tipo de dispositivo es{dispositivo1.tipo} \n la marca es {dispositivo1.marca} el color es dispositivo{dispositivo1.color}");


            Dispositivo.abrirAplicacion();

            Dispositivo.cerrarApp();

          

            



        }
    }


    public class Dispositivo
    {
        public string color { get; set; }

        public string marca { get; set; }

        public string tipo { get; set; }

        public static void abrirAplicacion()
        {
            Console.WriteLine("el dispositivo abre app");
        }

        public static void cerrarApp()
        {

            Console.WriteLine($"el dispositivo  cerro la app");
        }
    }
}




