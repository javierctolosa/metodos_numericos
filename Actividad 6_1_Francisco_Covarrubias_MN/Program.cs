using System;

namespace Actividad_6_1_Francisco_Javier_Covarrubias_Tolosa_MN
{
    class Program
{
    static void Main(string[] args)
    {
        double[,] matriz = { { 1, 2, 2, 1 },
                               { 3, 1, 2, 5 },
                              { 4, 3, 3, 8 } };
        double pivote, factor;
        Console.WriteLine("Bienvenido(a), este programa solucionará el siguiente problema utilizando el método de eliminación de Gauss." +
            "\nCuando hayas leído el caso presiona Enter para ver la solución.");
        Console.WriteLine("--------------------------------------------------------------------------------------");
        Console.WriteLine("| Un ingeniero financiero ha invertido en una constructora,                          |" +
            "\n| el producto adquirido contiene tres proyectos a elegir por el inversor,            |" +
            "\n| dentro de cada uno de estos puede puede comprar la cantidad deseada de bonos       |" +
            "\n| al inicio de mes, los productos elegidos se han de mantener por tres meses,        |" +
            "\n| una vez cumplido el plazo se podrá cambiar uno de los proyectos elegidos.          |" +
            "\n| El ingeniero financiero cuenta con la siguiente información:                       |" +
            "\n| 1er mes: 1 Bono en Valle Real, 2 Bonos en La Primavera Residencial,                |" +
            "\n| 2 Bonos en Villas del Río.Valor de la cartera al final del mes 1, 000, 000 MX.     |" +
            "\n| 2do mes: 3 Bonos en Valle Real, 1 Bono en La Primavera Residencial,                |" +
            "\n| 2 Bonos en Villas del Río.Valor de la cartera al final del mes 5, 000, 000 MX      |" +
            "\n| 3er mes: 4 Bonos en Valle Real, 3 Bonos en La Primavera Residencial,               |" +
            "\n| 3 Bonos en Villas del Río.Valor de la cartera al final del mes 8, 000, 000 MX      |" +
            "\n| Ahora que esta a punto de iniciar el cuarto mes, desea saber cuál de los           |" +
            "\n| proyectos es el que le está dando el menor de los rendimientos a fin de            |" +
            "\n| cambiarlo. Para esto te contrata a fin de que le ayudes a tomar la mejor decisión. |");
        Console.WriteLine("--------------------------------------------------------------------------------------\n");

        Console.ReadLine();

        Console.WriteLine("La matriz a utilizar para solucionar el problema es la siguiente:");
        for (int reng = 0; reng < 3; reng++)
        {
            for (int colu = 0; colu < 4; colu++)
            {
                Console.Write(matriz[reng, colu] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int reng = 0; reng < 3; reng = reng + 1)
        {
            //Selecciona el elemento diagonal como pivote
            pivote = matriz[reng, reng];

            //Divide todo el renglón entre el pivote
            for (int colu = 0; colu < 4; colu = colu + 1)
            {
                matriz[reng, colu] = matriz[reng, colu] / pivote;
            }
            //Elimina los elementos que están en la misma columna
            //que el pivote seleccionado.
            //Aquí seleccióna el renglón
            for (int reng_elimi = 0; reng_elimi < 3; reng_elimi = reng_elimi + 1)
            {
                if (reng_elimi != reng)
                {
                    //Selecciona el factor por el que se va a multplicar
                    //el renglón principal para eliminar el elemento
                    factor = matriz[reng_elimi, reng];

                    //Resta todo el renglón principal a el renglón a eliminar
                    for (int colu_elimi = 0; colu_elimi < 4;
                        colu_elimi = colu_elimi + 1)
                    {
                        matriz[reng_elimi, colu_elimi]
                            = matriz[reng_elimi, colu_elimi] - factor
                            * matriz[reng, colu_elimi];
                    }
                }
            }
        }
        Console.WriteLine("El valor de cada uno de los bonos en el proyecto Valle Real es: $ " + matriz[0, 3] * 1000000 + " MX");
        Console.WriteLine("El valor de cada uno de los bonos en el proyecto La Primavera Residencial es: $ " + matriz[1, 3] * 1000000 + " MX");
        Console.WriteLine("El valor de cada uno de los bonos en el proyecto Villas del Río es: $ " + matriz[2, 3] * 1000000 + " MX");
        Console.WriteLine("El proyecto Villas del Río es el que deberá de reemplazarse en la cartera al inicio del cuarto mes.");

        Console.ReadLine();
    }
}
}

