using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nacimiento_DiegoAyala
{
    class Program
    {
        static Int16 nacimiento()
        {
            //declararcion de variables
            Int16 nacimiento, edad, actual;
            actual = 2021;
            //entrada de datos
            Console.WriteLine("       CALCULADOR DE EDAD      ");
            Console.Write("Ingrese su año de nacimiento: ");
            nacimiento = Int16.Parse(Console.ReadLine());
            while (nacimiento < 0 || nacimiento > actual)
            {
                Console.Write("Ingrese un año de nacimiento valido: ");
                nacimiento = Convert.ToInt16(Console.ReadLine());
            }

            //procesos 
            edad = (short)(actual - nacimiento);

            return edad;
        }//fin funcion nacimiento

        static void imprimir(Int16 edad)
        {
            Console.WriteLine("Su edad actual es de {0} años ", edad);
            Console.ReadKey();
        }//fin funcion de impresion

        static void despedida()
        {
            Console.Clear();
            Console.WriteLine("Gracias por usar nuestro servicio");
            Console.WriteLine("...Cerrando programa...");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Int16 edad;
            edad = nacimiento();
            imprimir(edad);
            despedida();
        }
    }
}
