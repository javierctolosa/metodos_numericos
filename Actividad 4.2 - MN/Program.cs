using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Actividad_4._1___MN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido(a), este programa generará números basados en la serie: [(n^2)-3]/n. Se detendrá al llegar lo más cerca posible a 30 y te indicará a qué término de la serie corresponde la cifra calculada.");

            Console.WriteLine("La serie creada por la ecuación (((n^2)-3))/n) es: ");
            int n = 0;
            double x = 0;
            while (x < 30)
            {
                x = (Math.Pow(n, 2) - 3) / n;
                Console.WriteLine(x);
                n++;
            }
            Console.WriteLine("\n" + n);
            Console.WriteLine("Gracias por utilizar este programa, ojalá te haya sido de ayuda.");
            Console.ReadLine();

        }
    }
}
