using System;

namespace Metodos_EvidenciaFInal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Evidencia 3");
            Console.WriteLine("Ecuacion a resolver: V dc/dt = Q * cent - Q * c\n");

            // y = funcion a evaluar // yy derivada de la funcion.

            int v = 100, ce = 50, q = 5; //Asignacion de valores.
            double y, yy, t = 0, paso = 13; //Declaracion de funcion, derivada y el paso que se utilizara en el ciclo.

            y = 10; //Valor inicial de y supuesto en el problema

            while (t<=40) //Se asigna un ciclo de 0 a 40 para conocer los valores.
            {
                
                if (t>10 & t<10.01 || t>20 & t<20.01) //Arroja los valaores de Y cuando t pasa por 10 y 20
                {
                    Console.WriteLine("El valor de y es " + y + " cuando el tiempo es igual a " + t);
                }

                yy = (q * (ce - y)) / v; //Se asigna el valor mediante la derivada a y con t equivalente.

                y = y + yy * paso; //Se asigna valor a y cuando t es igual a cierto numero al igual que el incremento en paso.

                t = t + paso; //Se da el paso en cada ciclo.

            }
            
            Console.WriteLine("El valor de y es "+y+ " cuando el tiempo es igual a 40"); //Arroja el valor de y cuando t es igual a 40
            
            
            Console.WriteLine("Integrantes del equipo 5: ");
            Console.WriteLine("Maria Fernanda Corral Tovar ");
            Console.WriteLine("Gerardo Santos Lucas ");
            Console.WriteLine("Francisco Javier Covarrubias Tolosa");

        }
    }
}
