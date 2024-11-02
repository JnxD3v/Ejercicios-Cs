//Crear un programa que calcule el promedio de las 4 notas
//de un estudiante, determine si aprobó o reprobó, tomando
//en cuenta que, para aprobar la nota mínimo de 70 puntos, si reprobó,
//entonces el estudiante ira a completivo, para eso se calcula el 50% de 
//la nota promedio, colocar la nota del examen o prueba y de este también 
//se calcula el 50%, el resultado de la nota completiva es sumando los
//resultados de los 50%. Si aprueba, debe Mostrar en pantalla la nota y 
//determinar si aprobó o reprobó la parte completiva.Si reprobó entonces 
//el estudiante ira a extraordinario, donde se calculara el 30% de la 
//nota promedio, se introduce la nota de la prueba extraordinaria y 
//calcular e 70% de dicha nota.El resultado de la calificación extraordinaria 
//es el resultado de el 30% y el 70%. Si el estudiante aprobó se debe mostrar en 
//pantalla que aprobó colocando la nota y el mensaje de lo contrario reprobo.
//Mostrar en pantalla el nombre , la materia, la calificación obtenida ya sea Normal, 
//Completiva o Extraordinario y la situacion si aprobó o reprobo .


using System.ComponentModel;

namespace gamaEn_el_curso
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO A DONDE SABES SI TE QUEMASTE O NO");
            double nota1, nota2, nota3, nota4, promedio, notaExtraordinario, notaCompletivo;
            string materia, nombreEstudiante;

            Console.WriteLine("inserte la materia en la cual se esta evaluando");
            materia = Console.ReadLine();


            Console.WriteLine("inserte el nombre del estudiante el cual esta evualuando");
            nombreEstudiante = Console.ReadLine();


            Console.Write("INSERTA LA PRIMERA NOTA: ");
            nota1 = double.Parse(Console.ReadLine());
           
            Console.Write("INSERTA LA SEGUNDA  NOTA: ");
            nota2 = double.Parse(Console.ReadLine());
           
            Console.Write("INSERTA LA TERCERA NOTA: ");
            nota3 = double.Parse(Console.ReadLine());
            
            Console.Write("INSERTA LA PRIMERA NOTA: ");
            nota4 = double.Parse(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3 + nota4) / 4;
           

            if (promedio > 70)
            {
                Console.WriteLine($"El estudiante {nombreEstudiante} paso, no hay problema en la materia de {materia}");
                
            }
            else 
            {
                Console.WriteLine($"el estudiante  {nombreEstudiante} se quedo en recuperacio en la materia de {materia}");
                
                Console.Write("Cuanto saco el estudiante: ");
                
                notaCompletivo = double.Parse(Console.ReadLine());  
                
                notaCompletivo = (promedio * 0.5) + (notaCompletivo * 0.5);
                Console.WriteLine(notaCompletivo);
                if (notaCompletivo > 70)
                {
                    Console.WriteLine($"EL estudiante {nombreEstudiante} promovio el completivo en la materia de {materia}");
                    Console.WriteLine("la nota del estudiante es" + notaCompletivo);
                }

                else
                {
                    Console.WriteLine($"el estudiante {nombreEstudiante} se quedo en extraordinario(que nuv)");
                    Console.WriteLine("su nota es de" + notaCompletivo + "en la materia de" + materia);
                    Console.Write("inserte la nota de extraordinario del estudiante");
       
                    notaExtraordinario = double.Parse(Console.ReadLine());
                    notaExtraordinario = (promedio * 0.30) + (notaExtraordinario * 0.70);

                    if (notaExtraordinario > 70)
                    {
                        Console.WriteLine($"el estudiante {nombreEstudiante} a aprovado(paso a chepita)" + "en la materia" + materia);
                        Console.WriteLine($"la nota del estudiante {nombreEstudiante}  es" +notaExtraordinario + "en la materia" + materia);
                    }

                    else
                    {
                        Console.WriteLine($"el señor {nombreEstudiante} a reprobado(ese es muy bruto que no paso el extraordinario)");
                        Console.WriteLine($"la nota de {nombreEstudiante} es" + notaExtraordinario + "en la materia" + materia);
                    }
                }
        }

         
        }
    }
}
