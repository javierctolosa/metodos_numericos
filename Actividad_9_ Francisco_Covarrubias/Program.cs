using System;

namespace Actividad_9_Francisco_Covarrubias_MN
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double pivote, factor;
            double[,] jacobiana = new double[10, 3];
            double[,] matriz = new double[3, 4];

            //Temperaturas de cada mes
            double[] voltaje = { 7.2074, 10.5465, 9.7056, 8.2160, 10.2054, 16.6029, 24.2849,
            28.9468, 29.0606, 27.2799};
            double[] tiempo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < 10; i = i + 1)
            {
                jacobiana[i, 0] = voltaje[i];
                jacobiana[i, 1] = tiempo[i];
                jacobiana[i, 2] = Math.Cos(tiempo[i]);


            }

            for (int i = 0; i < 3; i = i + 1)
                for (int j = 0; j < 3; j = j + 1)
                    for (int k = 0; k < 10; k = k + 1)
                        matriz[i, j] = matriz[i, j] + jacobiana[k, i] * jacobiana[k, j];


            for (int i = 0; i < 3; i = i + 1)
                for (int j = 0; j < 1; j = j + 1)
                    for (int k = 0; k < 10; k = k + 1)
                        matriz[i, 3] = matriz[i, 3] - voltaje[k] * jacobiana[k, i];

            for (int reng = 0; reng < 3; reng = reng + 1)
            {
                pivote = matriz[reng, reng];
                for (int colu = 0; colu < 3; colu = colu + 1)
                    matriz[reng, colu] = matriz[reng, colu] / pivote;
                for (int reng_elimi = 0; reng_elimi < 3; reng_elimi = reng_elimi + 1)
                    if (reng_elimi != reng)
                    {
                        factor = matriz[reng_elimi, reng];
                        for (int colu_elimi = 0; colu_elimi < 3;
                            colu_elimi = colu_elimi + 1)
                            matriz[reng_elimi, colu_elimi] = matriz[reng_elimi,
                                colu_elimi] - factor * matriz[reng, colu_elimi];
                    }
            }

            //Imprime los valores de las variables
            Console.WriteLine(matriz[0, 3] + " " + matriz[1, 3] + " " + matriz[2, 3] + " ");


            Console.ReadLine();

        }

    }
}


