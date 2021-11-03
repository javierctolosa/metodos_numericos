using System;

namespace Integral_trapezoide
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inicio del código para el método de Integral trapezoide

            Console.WriteLine(" Buen día" );
            Console.WriteLine(" ");
            Console.WriteLine(" Se presenta el código del método Integral trapezoide para calcular la integral de la siguiente función ");
            Console.WriteLine(" ");
            Console.WriteLine(" y = -x3 + 10x2 + 8x + 10 "); // Función 1
            Console.WriteLine(" ");

            double base_rectangulo, altura_1, altura_2, altura_promedio, x; // A diferencia del método rectangular, en este caso se requiere declarar dos variables para las alturas
            double partes = 8, area = 0; // Corresponde al número de rectangulos para integrar el área total de la Función 1. (Consultar Ec. 1)
            Console.WriteLine(" El número de partes o reactangulos de la integración es igual a  " + partes);
            Console.WriteLine(" ");
            double lim_inferior = 3, lim_superior = 7;

            base_rectangulo = (lim_superior - lim_inferior) / partes; // Determina el ancho de cada base de cada rectangulo (Consultar Ec. 1)

            x = lim_inferior; // De acuerdo con la base_rectangulo, indica los valores de x con los que se deberá evaluar la Función 1

            Console.WriteLine(" El valor del límite inferior en x es igual a " + x);
            Console.WriteLine(" ");

            while (x < lim_superior) // Con este ciclo calcular la altura promedio de cada trapecio se multiplica por la base y se suma

            {
                altura_1 = -x * x * x + 10 * x * x + 8 * x + 10; // Corresponde a evaluar la Función 1 en el límite inferior de la base
                x = x + base_rectangulo;
                altura_2 = -x * x * x + 10 * x * x + 8 * x + 10; // Corresponde a evaluar la Función 1 en el límite superior de la base
                altura_promedio = (altura_1 + altura_2) / 2; // En este punto se calcula la altura promedio con la que se evaluara el área de cada rectangulo (Consultar Ec. 2)

                area = area + base_rectangulo * altura_promedio; // Fórmula para calcular el área de cada rectangulo que integra la Función 1

                Console.WriteLine(" El valor del límite superior es igual a " + x);

                Console.WriteLine("  El valor de la base es igual a " + base_rectangulo) ;

                Console.WriteLine(" La altura total es igual a " + altura_promedio);

                Console.WriteLine(" El área total es igual a " + area);
                Console.WriteLine(" ");

            }
            Console.WriteLine(" El valor del límite superior en x es igual a " + x);
            Console.WriteLine(" ");
            Console.WriteLine(" El valor del area total de la función es igual a " + area);
            Console.ReadLine();


        }
    }
}
