using System;

namespace Actividad_11_1_Francisco_Covarrubias_MN
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = { -2, -1, -0.3, 1.45, 4.3, 8, 9.56, 12.1, 23.5 };
            double[] y = { 5, 7.3, 1.23, -3.5, 3, 7.8, 0.1, 3.4, 2.3 };
            double[] l = new double[9];
            double x_0 = 5.234;
            double y_0 = 0;

            for (int i = 0; i < 9; i = i + 1)
            {
                l[i] = 1;
                for (int j = 0; j < 9; j = j + 1)
                {
                    if (i != j)
                    {
                        l[i] = l[i] * ((x_0 - x[j]) / (x[i] - x[j]));
                    }
                }
                y_0 = y_0 + l[i] * y[i];
            }
            Console.WriteLine("El valor de y en " + x_0 + " es " + y_0);
            Console.ReadLine();
        }
    }

}
