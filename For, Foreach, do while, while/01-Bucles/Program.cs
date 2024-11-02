namespace _21GAMALIER
{
//    //1.- Crear un programa que lea n cantidad de números enteros y determine cuantos son
//positivos, cuantos negativos, cuantos pares, cuantos impares, luego mostrar los
//resultados en pantalla.
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, impar, par, negativo, positivo, numerosAIngresar, contador, neutro;
            par = 0;
            impar = 0;
            negativo = 0;
            positivo = 0;
            contador = 0;
            neutro = 0;

            Console.Write("~INSERTE LA CANTIDAD DE NUMEROS QUE VA A INGRESAR: ");
            numerosAIngresar = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("inserta el numero: ");
                numero = int.Parse(Console.ReadLine());
                if (numero > 0 )
                {
                    positivo += 1;
                    if (numero % 2 == 0)
                    {
                        par += 1;
                    }

                    else
                    {
                        impar += 1;
                    }


                }

                else if(numero == 0)
                {
                    neutro++;

                }

              
                      else
                    {
                        negativo += 1;
                        if (numero % 2 == 0)
                        {
                            par += 1;
                        }
                        else
                        {
                            impar = +1;
                        }

                    }
                



                contador++;


            } while (numerosAIngresar > contador );

            Console.WriteLine("~GRACIAS POR JUGAR, LOS RESULTADOS SON");
            Console.WriteLine($"~Positivos :{positivo} \n ~Negativo: {negativo} \n ~Impar: {impar} \n Par: {par} \n Numero neutro(osea el 0){neutro}");


        }
    }
}
