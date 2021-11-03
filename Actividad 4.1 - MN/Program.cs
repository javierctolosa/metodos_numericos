using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Actividad_4._1___MN
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido(a), este programa te pedirá números menores a 50 hasta que ingreses el número 0, cuando lo hagas te mostrará cuántos números introdujiste, la moda, el promedio y el más grande de los números introducidos.");
            int numero = 1, i = 0;
            int[] arr = new int[1000];
            
            while (numero != 0)
            {
                Console.WriteLine("Ingrese un número menor a 50 (0 para detener):");
                numero = int.Parse(Console.ReadLine());
                while (numero < 0 || numero > 50)
                {
                    Console.WriteLine("Error; Ingrese un numero menor a 50");
                    numero = int.Parse(Console.ReadLine());
                }
                arr[i] = numero;
                i++;
            }
            //Promedio
            int suma = 0;
            for (int j = 0; j < i; j++)
            {
                suma += arr[j];
            }
            //Moda
            int Mode(int[] arreglo, int tamaño)
            {
                int result = 0, rep = 0, aux = 0, repu = 0;
                for (int k = 0; k < tamaño; k++)
                {
                    aux = arreglo[k];
                    for (int j = 0; j < tamaño; j++)
                    {
                        if (arreglo[j] == aux)
                        {
                            repu++;
                        }
                    }
                    if (repu > rep)
                    {
                        result = aux;
                        rep = repu;
                    }
                }
                return result;
            }
            Console.WriteLine("Cantidad de números ingresados: " + (i - 1));
            Console.WriteLine("Numero Mayor: " + arr.Max());
            Console.WriteLine("Promedio: " + (suma / (i - 1)));
            Console.WriteLine("Moda: " + Mode(arr, (i - 1)));
            Console.WriteLine("Gracias por utilizar este programa, ojalá te haya sido de ayuda.");

        }
    }
}
