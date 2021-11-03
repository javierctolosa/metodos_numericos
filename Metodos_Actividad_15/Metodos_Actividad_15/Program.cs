using System;

namespace Metodos_Actividad_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Método de Runge Kutta de segundo orden ");
            Console.WriteLine(" d2f(x)/dx2 = - 4 df(x)/dx + sen (x) ");
            Console.WriteLine(" Se requiere determinar el valor de f(x) cuando x es igual a 7 \n");
            Console.WriteLine(" f(x) = 7, en x = 2");
            Console.WriteLine(" df(x)/dx = 0, en x = 2 \n");
            Console.WriteLine(" Solución \n");

            double y, yy, yyy, k1, k2, k3, k4, ky1, ky2, ky3, ky4, x = 2, paso = 0.01;

            y = 7;
            yy = 0;

            while (x<7)
            {
                yyy = -4 * y + Math.Sin(x);

                ky1 = paso * (-4 * y + Math.Sin(x));

                k1 = yy;

                ky2 = paso * (-4 * (y + k1 * 0.5) + Math.Sin(x + paso * 0.5));

                k2 = paso * (yy + k1 * 0.5);

                ky3 = paso * (-4 * (y + k2 * 0.5) + Math.Sin(x + paso * 0.5));

                k3 = paso * (yy + k2 * 0.5);

                ky4 = paso * (-4 * (y + k2) + Math.Sin(x + paso));

                k4 = paso * (yy + k3);

                y = y + (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                yy = yy + (ky1 + 2 * ky2 + 2 * ky3 + ky4) / 6;

                x = x + paso;
         
            }
            Console.WriteLine(" ");
            Console.WriteLine(" Finalmente, cuando x es igual a " + x + " el valor de la función es igual a " + y);
        }
    }
}
