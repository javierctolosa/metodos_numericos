using System;

namespace Actividad_13_Francisco_Covarrubias_MN
{
    class Program
    {
        static void Main(string[] args)
        {
            double base_rectangulo, altura_1, altura_2, altura_3, altura_total, x;
            double partes = 2, area = 0;
            double lim_inferior = 0, lim_superior = 0.05;

            base_rectangulo = (lim_superior - lim_inferior) / partes;

            x = lim_inferior;
            double Area_1 = 0;

            while (x < lim_superior)
            {
                altura_1 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x );
                x = x + base_rectangulo / 2;
                altura_2 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x );
                x = x + base_rectangulo / 2;
                altura_3 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x );

                altura_total = (altura_1 + 4 * altura_2 + altura_3) / 6;
                Area_1 = area + (base_rectangulo) * altura_total;
            }

            lim_inferior = 0.05;
            lim_superior = 0.1;
            double Area_2 = 0;
            while (x < lim_superior)
            {
                altura_1 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_2 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_3 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);

                altura_total = (altura_1 + 4 * altura_2 + altura_3) / 6;
                Area_2 = area + (base_rectangulo) * altura_total;
            }

            lim_inferior = 0.1;
            lim_superior = 0.15;
            double Area_3 = 0;
            while (x < lim_superior)
            {
                altura_1 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_2 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_3 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);

                altura_total = (altura_1 + 4 * altura_2 + altura_3) / 6;
                Area_3 = area + (base_rectangulo) * altura_total;
            }

            lim_inferior = 0.15;
            lim_superior = 0.20;
            double Area_4 = 0;
            while (x < lim_superior)
            {
                altura_1 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_2 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_3 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);

                altura_total = (altura_1 + 4 * altura_2 + altura_3) / 6;
                Area_4 = area + (base_rectangulo) * altura_total;
            }

            lim_inferior = 0.20;
            lim_superior = 0.25;
            double Area_5 = 0;
            while (x < lim_superior)
            {
                altura_1 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_2 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_3 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);

                altura_total = (altura_1 + 4 * altura_2 + altura_3) / 6;
                Area_5 = area + (base_rectangulo) * altura_total;
            }

            lim_inferior = 0.25;
            lim_superior = 0.30;
            double Area_6 = 0;
            while (x < lim_superior)
            {
                altura_1 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_2 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_3 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);

                altura_total = (altura_1 + 4 * altura_2 + altura_3) / 6;
                Area_6 = area + (base_rectangulo) * altura_total;
            }

            lim_inferior = 0.30;
            lim_superior = 0.35;
            double Area_7 = 0;
            while (x < lim_superior)
            {
                altura_1 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_2 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_3 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);

                altura_total = (altura_1 + 4 * altura_2 + altura_3) / 6;
                Area_7 = area + (base_rectangulo) * altura_total;
            }

            lim_inferior = 0.35;
            lim_superior = 0.40;
            double Area_8 = 0;
            while (x < lim_superior)
            {
                altura_1 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_2 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_3 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);

                altura_total = (altura_1 + 4 * altura_2 + altura_3) / 6;
                Area_8 = area + (base_rectangulo) * altura_total;
            }

            lim_inferior = 0.40;
            lim_superior = 0.45;
            double Area_9 = 0;
            while (x < lim_superior)
            {
                altura_1 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_2 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_3 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);

                altura_total = (altura_1 + 4 * altura_2 + altura_3) / 6;
                Area_9 = area + (base_rectangulo) * altura_total;
            }

            lim_inferior = 0.45;
            lim_superior = 0.50;
            double Area_10 = 0;
            while (x < lim_superior)
            {
                altura_1 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_2 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_3 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);

                altura_total = (altura_1 + 4 * altura_2 + altura_3) / 6;
                Area_10 = area + (base_rectangulo) * altura_total;
            }

            lim_inferior = 0.50;
            lim_superior = 0.55;
            double Area_11 = 0;
            while (x < lim_superior)
            {
                altura_1 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_2 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_3 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);

                altura_total = (altura_1 + 4 * altura_2 + altura_3) / 6;
                Area_11 = area + (base_rectangulo) * altura_total;
            }

            lim_inferior = 0.55;
            lim_superior = 0.60;
            double Area_12 = 0;
            while (x < lim_superior)
            {
                altura_1 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_2 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_3 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);

                altura_total = (altura_1 + 4 * altura_2 + altura_3) / 6;
                Area_12 = area + (base_rectangulo) * altura_total;
            }

            lim_inferior = 0.60;
            lim_superior = 0.65;
            double Area_13 = 0;
            while (x < lim_superior)
            {
                altura_1 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_2 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_3 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);

                altura_total = (altura_1 + 4 * altura_2 + altura_3) / 6;
                Area_13 = area + (base_rectangulo) * altura_total;
            }

            lim_inferior = 0.65;
            lim_superior = 0.70;
            double Area_14 = 0;
            while (x < lim_superior)
            {
                altura_1 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_2 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_3 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);

                altura_total = (altura_1 + 4 * altura_2 + altura_3) / 6;
                Area_14 = area + (base_rectangulo) * altura_total;
            }

            lim_inferior = 0.7;
            lim_superior = 0.75;
            double Area_15 = 0;
            while (x < lim_superior)
            {
                altura_1 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_2 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_3 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);

                altura_total = (altura_1 + 4 * altura_2 + altura_3) / 6;
                Area_15 = area + (base_rectangulo) * altura_total;
            }

            lim_inferior = 0.75;
            lim_superior = 0.8;
            double Area_16 = 0;
            while (x < lim_superior)
            {
                altura_1 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_2 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);
                x = x + base_rectangulo / 2;
                altura_3 = (.2) + (0.25 * x) - (200 * x * x) + (675 * x * x * x) - (900 * x * x * x * x) + (400 * x * x * x * x * x);

                altura_total = (altura_1 + 4 * altura_2 + altura_3) / 6;
                Area_16 = area + (base_rectangulo) * altura_total;
            }


            Double Area_total = Area_1 + Area_2 + Area_3 + Area_4 + Area_5 + Area_6 + Area_7 + Area_8 + Area_9 + Area_10 + Area_11 + Area_12 + Area_13 + Area_14 + Area_15 + Area_16;
            Console.WriteLine("El valor del area es " + Area_total);
            Console.ReadLine();
        }

    }
    }

