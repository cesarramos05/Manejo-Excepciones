using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_Excepciones
{
   

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Variables 
                int num;
                Console.WriteLine("Programa que eleva al cuadrado un numero");
                Console.Write("Ingrese numero entero a calcular: ");
                num = int.Parse(Console.ReadLine());
                
                //Impresion y calculo
                Console.WriteLine("\nEl numero " + num + " al cuadrado es igual a: " + Math.Pow(num, 2));
            }
            catch (FormatException)
            {
                Console.WriteLine("\nNo cumple con el formato adecuado");
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nEl numero es muy grande");
            }
            Console.WriteLine("Ingrese ENTER para salir");
            Console.ReadKey();

        }
    }
}
