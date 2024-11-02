using System.Timers;

namespace gama17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double isr, sueldoBruto, afp, sfs, sueldoNeto, sueldoAnual;

            Console.WriteLine("INSERTA EL SUELDO BRUTO DEL EMPLEADO");
            sueldoBruto = double.Parse(Console.ReadLine());

            afp = sueldoBruto * 0.0287;
            sfs = sueldoBruto * 0.0304;
            sueldoNeto = sueldoBruto - sfs - afp;

            sueldoAnual = sueldoNeto * 12;
            isr = 0;

            if (sueldoAnual > 416220 & sueldoAnual < 624329)
            {
                isr = (sueldoAnual - 416220) * 0.15;
            }
            else if (sueldoAnual > 624329 & sueldoAnual < 867123)
            {
                isr = (31216 + (sueldoAnual - 416220)) * 0.20;
            }

            else if (sueldoAnual > 867123)
            {
                isr = (79776 + (sueldoAnual - 416220)) * 0.25;
            }

            else
            {
                Console.WriteLine("No aplica para el ISR");
            }

            Console.WriteLine("el sueldo bruto es de" + " " + sueldoBruto);
            Console.WriteLine("el descuento de AFP es de" + " " + afp);
            Console.WriteLine("el descuento de sfs es de" + " " + sfs);
            Console.WriteLine("el sueldo neto es de"+ " " + sueldoNeto);
            Console.WriteLine("el sueldo neto anual es de" + " " + sueldoAnual);
            Console.WriteLine("el descuento total de isr sera de" + " " + isr);
        }





            }
    }

