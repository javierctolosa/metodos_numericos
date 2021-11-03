using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Actividad_4._3___MN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido(a), este programa generará los números primos de 1 hasta 1000.");
            Console.WriteLine("La serie de numeros primos es hasta 1000: ");
            int contador = 0; //contador>2 == No es primo                      contador<2 == Si es primo
            for (int k = 3; k <= 1000; k++)
            {
                for (int l = 1; l <= k; l++)
                {
                    if (k % l == 0)
                    {
                        contador = contador + 1;
                    }
                }
                if (contador <= 2)
                {
                    Console.WriteLine(k);
                }
                contador = 0;
            }

            Console.WriteLine("Gracias por utilizar este programa, ojalá te haya sido de ayuda.");
        }
     
        

        
    }
}
