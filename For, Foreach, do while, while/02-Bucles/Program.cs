using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _22GAMALIER
{
//    2.- Crear un programa que lea una contraseña, si es incorrecta, mostrar un mensaje
//que lo indique y tenga como máximo 3 intentos, luego después de esos intentos,
//mostrar un mensaje indicando que ha agotado el numero de intentos y el programa
//debe terminar
    internal class Program
    {
        static void Main(string[] args)
        {
            string contraseña;

            contraseña = "ADMIN";

            Console.WriteLine($"la contraseña es: {contraseña}");
             
            

            Console.Write("INSERTA LA CONTRASEÑA: ");
            contraseña = Console.ReadLine();



            if (contraseña == "ADMIN")
            {
                Console.WriteLine("felicidades acertaste a la primera");
            }


            else {

                for (int i = 0; i < 3;i++)
                {
                    Console.WriteLine("vuelve a ingresar la contraseña: ");
                    contraseña = Console.ReadLine();

                   
                }

                Console.WriteLine("fallaste");
            }

            Console.WriteLine("el programa ah culminado");
        }
    }
}
