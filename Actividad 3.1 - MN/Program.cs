using System;

namespace Actividad_3._1___MN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido(a), este programa te asiste en multiplicar una matriz por un número escalar");//Mensaje para el usuario
            int renglones, columnas;
            Console.Write("¿Cuántos renglones tiene tu matriz?\t");
            renglones = int.Parse(Console.ReadLine());
            Console.Write("¿Cuántas columnas tiene tu matriz?\t");
            columnas = int.Parse(Console.ReadLine());
            int[,] matriz = new int[columnas, renglones];
            //For para llenar el arreglo
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < renglones; j++)
                {
                    Console.Write("Ingresa el número en la posición [" + (i + 1) + "][" + (j + 1) + "] de la matriz: ");//Pedimos el valor de cada una de los números en base a sus posiciones en la matriz
                    matriz[i, j] = int.Parse(Console.ReadLine());//Almacena el valor a la matriz
                }//Fin de for j
            }//Fin for i
            //Fin de for para llenar la matriz -Inicio de for para imprimir la matriz
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < renglones; j++)
                {
                    Console.WriteLine("El valor de [" + (i + 1) + "][" + (j + 1) + "] es: " + matriz[i, j]);//Imprmime el valor de la matriz en su posición
                }//Fin de for j
            }//Fin for i
            Console.Write("Ingresa el valor por el que deseas multiplicar la matriz: ");//Instrucción para el usuario
            int multiplo = int.Parse(Console.ReadLine());//Ingresamos Valor            
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j < renglones; j++)
                {
                    int multiplica = 0;//Asignamos el valor
                    multiplica = matriz[i, j] * multiplo;//Hacemos operación
                    Console.WriteLine("El nuevo valor de [" + (i + 1) + "][" + (j + 1) + "] es: " + multiplica);//Imprime el valor de la matriz en su posición
                }//Fin de for j
            }//Fin for i
            Console.Write("Gracias por utilizar este programa, ojalá te haya sido de utilidad.");
            Console.ReadLine();
        }
    }
}

        
    

