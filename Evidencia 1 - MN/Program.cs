using System;

namespace Evidencia_1_MN
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = { { 100, 100, 5000 },
                               { 90, 80, 4300 }};
            double pivote, factor;

            for (int reng = 0; reng < 2; reng = reng + 1)
            {
                //Selecciona el elemento diagonal como pivote
                pivote = matriz[reng, reng];

                //Divide todo el renglón entre el pivote
                for (int colu = 0; colu < 3; colu = colu + 1)
                {
                    matriz[reng, colu] = matriz[reng, colu] / pivote;
                }
                //Elimina los elementos que están en la misma columna
                //que el pivote seleccionado.
                //Aquí seleccióna el renglón
                for (int reng_elimi = 0; reng_elimi < 2; reng_elimi = reng_elimi + 1)
                {
                    if (reng_elimi != reng)
                    {
                        //Selecciona el factor por el que se va a multplicar
                        //el renglón principal para eliminar el elemento
                        factor = matriz[reng_elimi, reng];

                        //Resta todo el renglón principal a el renglón a eliminar
                        for (int colu_elimi = 0; colu_elimi < 3;
                            colu_elimi = colu_elimi + 1)
                        {
                            matriz[reng_elimi, colu_elimi]
                                = matriz[reng_elimi, colu_elimi] - factor
                                * matriz[reng, colu_elimi];
                        }
                    }
                }
            }

            //Se imprime la descripción del problema y el resultado
            Console.WriteLine("La empresa ´´Innovación´´, dedicada a la producción de accesorios de computadora, cuenta con dos líneas de producción de unidades de discos duros. Trabajando al 100 %, el total de producción, sumando la línea 1 y la línea 2, es de 5000 unidades de discos duros. Por cuestiones de falta de componentes, en el 2019, la línea 1 operó a un 90 % de su capacidad, mientras que la línea 2 operó a tan solo el 80 % de su capacidad total. Por esta razón, en el 2019 la producción total fue de 4300 unidades de discos duros. Con base en lo anterior, determina cuál es capacidad de producción total de unidad de discos duros, tanto de la línea 1 como de la línea 2.");
            Console.WriteLine("La capacidad total de la línea de producción 1 es de: " + 100*matriz[0, 2] + " Discos duros.");
            Console.WriteLine("La capacidad total de la línea de producción 2 es de: " + 100*matriz[1, 2] + " Discos duros.");

        }
    }
}

