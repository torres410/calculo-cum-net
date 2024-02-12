using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int  ciclo, cantidad, uv, uvfinal = 0;
            double cum, cumfinal = 0;
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*** BIENVENIDO AL SISTEMA PARA CALCULAR SU CUM GLOBAL ***");
            Console.WriteLine(" ");

            Console.Write("¿En qué ciclo se encuentra? (digite el número): ");
            ciclo = Convert.ToInt32(Console.ReadLine());                                             

            if (ciclo != 1)
            {
                Console.WriteLine(" ");
                Console.Write("Cantidad de módulos cursados: ");
                cantidad = Convert.ToInt32(Console.ReadLine());

                string[] nombre_mod = new string[cantidad];
                double[] nota = new double[cantidad];
                int[] uValorativas = new int[cantidad];

                int errorsito = 0;                               

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("*** INGRESE EL NOMBRE DE LOS MÓDULOS, NOTA FINAL Y UNIDADES VALORATIVAS ***");


                for (int i = 0; i < cantidad; i++)               
                {
                    Console.WriteLine(" ");
                    Console.Write("Nombre del módulo: ");
                    nombre_mod[i] = Convert.ToString(Console.ReadLine());

                    Console.Write("Nota: ");
                    nota[i] = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Unidades valorativas: ");
                    errorsito = Convert.ToInt32(Console.ReadLine());
                    

                    if (errorsito < 4)
                    {                        
                        Console.WriteLine(" ");
                        Console.WriteLine("         ¡ERROR! - Las UV no pueden ser menores que 4.");
                    }
                    else
                    {
                        uValorativas[i] = errorsito;
                    }

                }

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("*** A CONTINUACIÓN SE MUESTRAN LAS ASIGNATURAS QUE USTED HA CURSADO CON SUS RESPECTIVAS NOTAS Y UNIDADES VALORATIVAS ***");

               
                for (int i = 0; i < nota.Length; i++)
                {
                    cum = nota[i] * uValorativas[i];
                    cumfinal = cum + cumfinal;
                    uv = uValorativas[i];
                    uvfinal = uv + uvfinal;
                }
                cum = cumfinal / uvfinal;

                for (int i = 0; i < nombre_mod.Length; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Módulo: " + nombre_mod[i]);
                    Console.WriteLine("Nota: " + nota[i]);
                    Console.WriteLine("UV: " + uValorativas[i]);
                                        
                   
                }

                Console.WriteLine(" ");
                Console.WriteLine("*** A CONTINUACIÓN SE MUESTRA LA NOTA DE SU CUM ***");
                Console.WriteLine(" ");
                Console.WriteLine("                     " + cum);
                Console.ReadKey();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" ");
                Console.WriteLine("¡ERROR! - No se puede calcular su CUM global si aún está en su primer ciclo.");
            }
            
            Console.ReadLine();
        }

    }
}
