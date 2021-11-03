using System;

namespace Practica_1
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor_1 = 0;
            float valor_2 = 0;
            float valor_3 = 0;
            float valor_4 = 0;
            float operacion_1 = 0;
            float operacion_2 = 0;
            float operacion_3 = 0;
            float operacion_4 = 0;

            bool compara_1;
            bool compara_2;
            bool compara_3;
            bool compara_4;
            bool compara_5;
            bool compara_6;

            Console.WriteLine("Ingresa valor 1: ");
            valor_1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa valor 2: ");
            valor_2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa valor 3: ");
            valor_3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa valor 4: ");
            valor_4 = float.Parse(Console.ReadLine());

            operacion_1 = (valor_1 + valor_2 + valor_3 + valor_4);
            operacion_2 = (valor_1 * valor_2 * valor_3 * valor_4);
            operacion_3 = ((valor_1 / valor_2) + (valor_3 / valor_4));
            operacion_4 = (operacion_1 + operacion_2);

            compara_1 = valor_1 != valor_2;
            compara_2 = valor_2 == valor_4;
            compara_3 = (valor_1 > valor_3) | (valor_1 > valor_4);
            compara_4 = valor_2 < operacion_3;
            compara_5 = compara_1 & compara_2;
            compara_6 = compara_3 | compara_4;

            Console.WriteLine("Operacion 1: " + operacion_1);
            Console.WriteLine("Operacion 2: " + operacion_2);
            Console.WriteLine("Operacion 3: " + operacion_3);
            Console.WriteLine("Operacion 4: " + operacion_4);

            Console.WriteLine("Comparacion 1: " + compara_1);
            Console.WriteLine("Comparacion 2: " + compara_2);
            Console.WriteLine("Comparacion 3: " + compara_3);
            Console.WriteLine("Comparacion 4: " + compara_4);
            Console.WriteLine("Comparacion 5: " + compara_5);
            Console.WriteLine("Comparacion 6: " + compara_6);
        }
    }
}
