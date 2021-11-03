using System;

namespace Actividad_12_2_Francisco_Covarrubias_MN
{
    class Program
    {
        static void Main(string[] args)
        {
            double base_rectangulo, altura_1, altura_2, altura_total, x;
            double partes = 1000, area = 0;
            double lim_inferior = -10, lim_superior = 10;

            base_rectangulo = (lim_superior - lim_inferior) / partes;

            x = lim_inferior;

            while (x < lim_superior)
            {
                altura_1 = Math.Sin(x) / x + 1;
                x = x + base_rectangulo;
                altura_2 = Math.Sin(x) / x + 1;
                altura_total = (altura_1 + altura_2) / 2;

                area = area + base_rectangulo * altura_total;

            }
            Console.WriteLine("El valor del area es " + area);
            Console.ReadLine();
        }
    }

}
   