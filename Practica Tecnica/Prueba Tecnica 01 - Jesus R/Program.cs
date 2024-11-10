using System;

namespace pruebaTecnica_01_JesusJuniorRod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   Bienvenido a las reservaciones del estadio de futbol  ");

            string[,] asientos = new string[10, 10];

            
            for (int i = 0; i < asientos.GetLength(0); i++)
            {
                for (int j = 0; j < asientos.GetLength(1); j++)
                {
                    asientos[i, j] = "L";
                }
            }

            string r;
            do
            {
                Console.WriteLine("\nOpciones: \n ~{0} Mostrar asientos disponibles \n ~{1} Reservar asientos");
                Console.Write("¿Qué desea hacer? (0 o 1): ");

                int acciones = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (acciones)
                {
                    case 0:
                        Console.WriteLine("\nAsientos disponibles:");
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write($"F {i} ~ ");
                            for (int j = 0; j < 10; j++)
                            {
                                Console.Write($"|{asientos[i, j]}| ");
                            }
                            Console.WriteLine();
                        }
                        break;

                        Console.WriteLine();

                    case 1:
                        Console.Write("Inserte la fila del asiento que desea: ");
                        int fila = int.Parse(Console.ReadLine());

                        Console.Write("Inserta la columna del asiento que desea: ");
                        int columna = int.Parse(Console.ReadLine());

                        if (fila >= 0 && fila < 10 && columna >= 0 && columna < 10)
                        {
                            if (asientos[fila, columna] == "L")
                            {
                                Console.WriteLine();
                                asientos[fila, columna] = "X";
                                Console.WriteLine("El asiento ha sido reservado con éxito.");

                                
                                for (int i = 0; i < 10; i++)
                                {
                                    Console.Write($"F {i} ~ ");
                                    for (int j = 0; j < 10; j++)
                                    {
                                        Console.Write($"|{asientos[i, j]}| ");
                                    }
                                    Console.WriteLine();
                                }
                            }

                            


                            


                        else
                            {
                                Console.WriteLine();
                                Console.WriteLine("El asiento ya está reservado.");
                                Console.Write("~Desea reservar otro asiento: ");
                                r = Console.ReadLine().ToLower();

                               

                                if (r == "si")
                                {


                                    Console.WriteLine();
                                    Console.Write("~Inserte fila del asiento: ");
                                    fila = int.Parse(Console.ReadLine());

                                    

                                    Console.Write("~Inserte la columna del asiento: ");
                                    columna = int.Parse(Console.ReadLine());

                                    Console.WriteLine();

                                    

                                    if (asientos[fila,columna ] == "L")
                                    {
                                        asientos[fila,columna] = "X";
                                        Console.WriteLine("Ahora si escogio uno que este libre");
                                        Console.WriteLine();

                                        
                                    }

                                    else
                                    {
                                        Console.WriteLine("Seras pendejo no te acabo de decir que ya esta reservado");
                                    }

                                }

                                else
                                {
                                    Console.WriteLine("Se entiende que solo quiera ese, pero aqui somo serio no como en enfermeria B)");
                                }

                                 


                                for (int i = 0; i < 10; i++)
                                {
                                    Console.Write($"F {i} ~ ");
                                    for (int j = 0; j < 10; j++)
                                    {
                                        Console.Write($"|{asientos[i, j]}| ");
                                    }
                                    Console.WriteLine();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("El asiento seleccionado no es válido.");


                        }
                        break;

                }


                Console.WriteLine("\n¿Deseas volver al menú principal? (si / no): ");
                r = Console.ReadLine().ToLower();

                Console.Clear();

            }

            while (r == "si");

            Console.WriteLine("Gracias por utilizar el sistema de reservaciones. ¡Hasta pronto!");
        }
    }
}
