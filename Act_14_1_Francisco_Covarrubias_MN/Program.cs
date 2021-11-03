using System;

namespace Act_14_1_Francisco_Covarrubias_MN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  En este programa se implementara el método Runge Kutta   ");
            Console.WriteLine("  La derivada de la función a evaluar es la siguiente:   ");
            Console.WriteLine("  df(x)/dy = (4x - 2f(x)) / 3   ");

        

            double y, k1, k2, k3, k4;
            double x = 0, paso = 2;      

            y = 1;                         

            while (x < 2)              
                                        
            {

                k1 = (-2 * y + 4 * x) / 3;

                k2 = (-2 * (y + .5 * k1 * paso) + 4 * (x + 0.5 * paso)) / 3;
                k3 = (-2 * (y + .5 * k2 * paso) + 4 * (x + 0.5 * paso)) / 3;

                k4 = (-2 * (y + k3 * paso) + 4 * (x + paso)) / 3;

                y = y + (k1 + 2 * k2 + 2 * k3 + k4) * paso / 6; 

                x = x + paso;

                Console.WriteLine(x);
            }

            Console.WriteLine("El valor de y cuando x es " + x + " es " + y);

            Console.ReadLine();
        }
    }
}
