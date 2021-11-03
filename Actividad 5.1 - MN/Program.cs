using System;

namespace Actividad_5_Programa_1_MN
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double paso = 0.01, sol_1, sol_2 = 0;

                for (double i = -10; i <= 10; i = i + paso)
                {
                    sol_1 = Math.Pow(Math.Acos(i / 5), 2) - Math.Sin(i / 10);

                    if (sol_1 * sol_2 < 0)
                    {
                        Console.WriteLine("La solución es: " + i);
                    }

                    sol_2 = sol_1;
                }

                Console.ReadLine();
            }
        }
    }
}
