using System;

namespace Actividad_2._2___MN
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int multiplicacion = 1;

            for (int i = 1; i <= 10; i++) 
            {
                multiplicacion = multiplicacion * i;
                suma = suma + i;
                                            }
            Console.WriteLine("La multiplicacion de todos es: " + multiplicacion);
            Console.WriteLine("La suma de todos es: " + suma);
                    }
    }
}
