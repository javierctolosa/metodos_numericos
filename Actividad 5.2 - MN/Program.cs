using System;

namespace Actividad_5_Programa_2_MN
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = { { 6, 2, 15 },
                               { 4, -5, 20 }};
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
         
            //Se imprime el resultado
           Console.WriteLine("El valor de X es = " + matriz[0,2]);
           Console.WriteLine("El valor de Y es = " + matriz[1, 2]);
                    
                }
            }
        }
    

