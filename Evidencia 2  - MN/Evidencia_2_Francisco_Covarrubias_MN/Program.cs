using System;

namespace Evidencia_2_Francisco_Covarrubias_MN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Impresión del problema a resolver
            Console.WriteLine("Bienvenido(a), este programa soluciona el siguiente problema,\n" +
                "utilizando el ajuste de curva por el método de mínimos cuadrados:\n" +
                "\nEncuentra los coeficientes que se ajusten a los siguientes datos:\n" +
                "t              f(t)\n" +
                "1              7.2074\n" +
                "2              10.546\n" +
                "3              9.7056\n" +
                "4              8.2160\n" +
                "5              10.2054\n" +
                "6              16.6029\n" +
                "7              24.2849\n" +
                "8              28.9468\n" +
                "9              29.0606\n" +
                "10             27.2799\n" +
               "\nSiguiendo la siguiente ecuación f(t)=X1 + X2 t + X3 cos(X4 t + X6)\n");
            double pivote, factor;

            double[,] jacobiana = new double[10, 3];
            double[,] matriz = new double[3, 4];

            //Datos
            double[] ft = { 7.2074, 10.5465, 9.7056, 8.2160, 10.2054, 16.6029, 24.2849, 28.9468, 29.0606, 27.2799 };
            double[] t = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16,
                                  17, 18, 19, 20};

            //Procesamos los datos en la matriz jacobiana para poder encontrar una matriz que se pueda solucionar por el método de eliminación de Gauss
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


            //Eliminación por el método de Gauss
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

            //Impresión de los valores de las variables ajustadas
            Console.WriteLine("El valor de las variables es:" +
                "\nX1: " + matriz[0, 3] +
                "\nX2: " + matriz[1, 3] +
                "\nX3: " + matriz[2, 3]);

            //Console.ReadLine();
        }
    }
}
