using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carla_Sandoval_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo System.Convert
            string texto = "50";
            Console.WriteLine("El valor actual es una cadena de texto: " + texto);
            Console.WriteLine(Convert.ToInt32(texto) + " Fue convertido");

            //Ejemplo .ToString
            decimal valor = 7654321.39503305M;
            string str = valor.ToString();
            Console.WriteLine("El valor de string es {0}", str);

            //Ejemplo .Parse
            string y = "100";

            try
            {
                int x = Int32.Parse(y);
                Console.WriteLine(x);
            }
            catch (FormatException)
            {
                Console.WriteLine("La cadena de texto ingresada es invalida.");
            }

        }
    }
    
}
