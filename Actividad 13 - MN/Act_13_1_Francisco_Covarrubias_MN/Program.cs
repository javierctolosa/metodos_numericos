using System;

namespace Act_13_1_Francisco_Covarrubias_MN
{
    class Program
    {
        static void Main(string[] args)
        {
            double base_rectangulo, altura_1, altura_2, altura_3, altura_total, x;
            double partes = 2, area = 0;
            double lim_inferior = 0, lim_superior = 0.8;

            base_rectangulo = (lim_superior - lim_inferior) / partes;

            x = lim_inferior;

            while (x < lim_superior)
            {
                altura_1 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_2 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_3 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);

                altura_total = (altura_1 + 4 * altura_2 + altura_3) / 6;
                area = area + (base_rectangulo) * altura_total;
            }

            Console.WriteLine("El area total debajo de la curva es:" + area);
        }
    }
}
