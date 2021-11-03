using System;

namespace Integral_rectangular
{
    class Program
    {
        static void Main(string[] args)
        {
            // En este punto se da inicia con el programa del método de integral rectangular

            Console.WriteLine(" Por medio del método de integral rectangular, se calulará el área de la siguiente función ");
            Console.WriteLine("");
            Console.WriteLine(" y = -x3 + 10x2 + 8x + 10"); // ´´Función 1´´
            Console.WriteLine("");


            double base_rectangulo, altura_rectangulo, x;
            double partes = 8, area = 0;    // El número de ''partes'' define el número de rectangulos (Consultar Ec. 1)
            Console.WriteLine(" El número de partes o reactangulos de la integración es igual a  " + partes);
            Console.WriteLine(" ");
            double lim_inferior = 3, lim_superior = 7; 

            base_rectangulo = (lim_superior - lim_inferior) / partes; // Determina el ancho de cada base de cada rectangulo (Consultar Ec. 1)

            x = lim_inferior; // Punto de inicio de la base para el área total de la función
                              // En est punto se da inicio con el ciclo para calcular las áreas de cada rectangulo
            Console.WriteLine(" El valor del límite inferior en x es igual a " + x);
            Console.WriteLine(" ");

            while (x < lim_superior) // Con este ciclo calcular la altura promedio de cada trapecio se multiplica por la base y se suma
            {
                altura_rectangulo = -x * x * x + 10 * x * x + 8 * x + 10; // Esto equivale a evaluar la ´´Función 1´´ en cada valor de x
                area = area + base_rectangulo * altura_rectangulo; // Fórmula para calcular el área de cada rectangulo que integra la Función 1
                x = x + base_rectangulo;

                Console.WriteLine(" El valor del límite superior es igual a " + x);

                Console.WriteLine(" El valor de la base es igual a " + base_rectangulo);

                Console.WriteLine(" La altura total, es decir la función (y) evaluada en x es igual a " + altura_rectangulo);

                Console.WriteLine(" El área total es igual a " + area);
                Console.WriteLine(" ");

            }

            Console.WriteLine(" El valor del límite superior en x es igual a " + x);
            Console.WriteLine(" ");
            Console.WriteLine(" El valor aproximado del area de la función es " + area);
            Console.ReadLine();


        }
    }
}
