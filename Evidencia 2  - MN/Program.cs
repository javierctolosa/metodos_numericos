using System;

namespace Evidencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Evidencia 2 - Resuelta por el metodo de los minumos cuadrados.\n" +
                "\n Funcion a evaluar: f(t)=X1 + X2 t + X3 cos(X4 t + X6)\n" +
                "Datos: t=1, 7.2074 - t=2, 10.5465 - t=3, 9.7056, t=4, 8.2160, t=5, 10.2054 \n" +
                "       t=6, 16.6029 - t=7, 24.2849 - t=8, 28.9468 - t=9, 29.0606 - t=10, 27.2799");
            double pivote, factor;

            double[,] jacobiana = new double[10, 3];
            double[,] matriz = new double[3, 4];

            //Datos del problema
            double[] ft = { 7.2074, 10.5465, 9.7056, 8.2160, 10.2054, 16.6029, 24.2849, 28.9468, 29.0606, 27.2799 };
            double[] t = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16,
                                  17, 18, 19, 20};

            //Se introducen los datos en una matriz Jacobiana para poder ser procesados y poder obtener nuestras 3 variables
            //para poder utilizar la eliminación Gaussiana
            for (int i = 0; i < 10; i = i + 1)
            {
                jacobiana[i, 0] = t[i] * t[i];
                jacobiana[i, 1] = Math.Sin(t[i]);
                jacobiana[i, 2] = Math.Exp(t[i] / 10);
            }

            //Multiplicación de matrices
            //------------------------------
            for (int i = 0; i < 3; i = i + 1)
                for (int j = 0; j < 3; j = j + 1)
                    for (int k = 0; k < 10; k = k + 1)
                        matriz[i, j] = matriz[i, j] + jacobiana[k, i] * jacobiana[k, j];

            for (int i = 0; i < 3; i = i + 1)
                for (int j = 0; j < 1; j = j + 1)
                    for (int k = 0; k < 10; k = k + 1)
                        matriz[i, 3] = matriz[i, 3] - ft[k] * jacobiana[k, i];
            

            //Eliminación por Gauss
            for (int reng = 0; reng < 3; reng = reng + 1)
            {
                pivote = matriz[reng, reng];
                for (int colu = 0; colu < 4; colu = colu + 1)
                    matriz[reng, colu] = matriz[reng, colu] / pivote;
                for (int reng_elimi = 0; reng_elimi < 3; reng_elimi = reng_elimi + 1)
                    if (reng_elimi != reng)
                    {
                        factor = matriz[reng_elimi, reng];
                        for (int colu_elimi = 0; colu_elimi < 4;
                            colu_elimi = colu_elimi + 1)
                            matriz[reng_elimi, colu_elimi] = matriz[reng_elimi,
                                colu_elimi] - factor * matriz[reng, colu_elimi];
                    }
            }

            //Imprime los valores de las variables
            Console.WriteLine("El resultado obtenido es     \nX1:                   X2:                X3:");
            Console.WriteLine(matriz[0, 3] + " " + matriz[1, 3] + " " + matriz[2, 3] + " ");

            //Console.ReadLine();

        }
    }
}
