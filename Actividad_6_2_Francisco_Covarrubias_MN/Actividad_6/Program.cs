using System;

namespace Actividad_6
{
    class Program
    {
        static void Main(string[] args)
        {
 
            double[,] matriz = new double[5,6];
            double pivote, factor;

            Console.WriteLine("Ingresa los valores de la matriz: ");
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 6; y++)
                {

                    Console.WriteLine("Ingresa valor de la posicion: " + x + "," + y);
                    int relleno = int.Parse(Console.ReadLine());
                    matriz[x, y] = relleno;
                }
            }
            Console.WriteLine("\nLa Matriz quedó de la siguiente Manera:  ");
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 6; y++)
                {

                    Console.Write(matriz[x, y] + " ");
                }
                Console.WriteLine();
            }
          

            for (int reng = 0; reng < 5; reng = reng + 1)
            {
                //Selecciona el elemento diagonal como pivote
                pivote = matriz[reng, reng];
                if (pivote == 0)
                {
                    Console.WriteLine("Este sistema No tiene Solucion por medio del metrod de Gauss ... ");
                }
                //Divide todo el renglón entre el pivote
                for (int colu = 0; colu < 6; colu = colu + 1)
                {
                    matriz[reng, colu] = matriz[reng, colu] / pivote;
                }
                //Elimina los elementos que están en la misma columna
                //que el pivote seleccionado.
                //Aquí seleccióna el renglón
                for (int reng_elimi = 0; reng_elimi < 5; reng_elimi = reng_elimi + 1)
                {
                    if (reng_elimi != reng)
                    {
                        //Selecciona el factor por el que se va a multiplicar
                        //el renglón principal para eliminar el elemento
                        factor = matriz[reng_elimi, reng];

                        //Resta todo el renglón principal a el renglón a eliminar
                        for (int colu_elimi = 0; colu_elimi < 6;
                            colu_elimi = colu_elimi + 1)
                        {
                            matriz[reng_elimi, colu_elimi]
                                = matriz[reng_elimi, colu_elimi] - factor
                                * matriz[reng, colu_elimi];
                        }
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("\nEl Resultado de la Matriz: ");
            for (int x = 0; x < 5; x++)
            {
                for (int y = 0; y < 6; y++)
                {
                    
                    Console.Write(matriz[x, y] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("El valor de la Primera variable es: " + matriz[0, 5]);
            Console.WriteLine("El valor de la Segunda variable es: " + matriz[1, 5]);
            Console.WriteLine("El valor de la Tercera variable es: " + matriz[2, 5]);
            Console.WriteLine("El valor de la Cuarta variable es: " + matriz[3, 5]);
            Console.WriteLine("El valor de la Quinta variable es: " + matriz[4, 5]);

            Console.ReadLine();
        }
    }
}
