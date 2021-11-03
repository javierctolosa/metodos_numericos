using System;

namespace Actividad_12_Francisco_Covarrubias_MN
{
    class Program
    {
        static void Main(string[] args)
        {
            double base_rectangulo, altura_rectangulo, x;
            double partes = 1000, area = 0;
            double lim_inferior = -10, lim_superior = 10;

            base_rectangulo = (lim_superior - lim_inferior) / partes;

            x = lim_inferior;

            while (x < lim_superior)
            {
                altura_rectangulo = Math.Sin(x) / x + 1;
                area = area + base_rectangulo * altura_rectangulo;
                x = x + base_rectangulo;
            }

            Console.WriteLine("El valor del area es " + area);
            Console.ReadLine();
        }
    }

}
    
