using System;

namespace Actividad_3._2___MN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido(a), este programa te asistirá en obtener el promedio de las calificaciones de tu semestre.");

            double promedio, suma = 0;//Declaramos variables
            Console.Write("¿Cuantas materias cursas o has cursado durante el semestre?  ");
            int cuantas = int.Parse(Console.ReadLine());//Almacenamos el número ingresado por el usuario
            int[] calificaciones = new int[cuantas];//Declaramos arreglo y asignamos tamaño
            for (int i = 0; i < cuantas; i++)
            {
                Console.Write("Ingresa tu calificación de la materia " + (i + 1) + ": ");
                calificaciones[i] = int.Parse(Console.ReadLine());//Almacenamos el número ingresado por el usuario
            }
            for (int j = 0; j < cuantas; j++)
            {
                suma = suma + calificaciones[j];//hacemos que suma sume su valor anterior y el valor actual del arreglo
            }
            promedio = suma / cuantas;//Hacemos la operación de promedio
            Console.WriteLine("Tu promedio del semestre es: " + promedio);//Imprimimos el valor del Promedio
            if (promedio < 70)
            {//Si su promedio es menor a 70
                Console.WriteLine("Estas reprobando o has reprobado algunas materias en el semestre.");//Mensaje para el usuario
            }
            else if (promedio < 85)
            {//si su promedio es menor a 85
                Console.WriteLine("Seguro has aprobado una parte de tus materias, sé que puedes mejorar ese promedio.");//Mensaje para el usuario
            }
            else if (promedio < 95)
            {//si su promedio es menor a 95
                Console.WriteLine("Eres un excelente estudiante.");//Mensaje para el usuario
            }
            else
            {//Si no se cumplió ninguna anterior
                Console.WriteLine("Eres un estudiante excepcional ¡FELICIDADES!");//Mensaje para el usuario
            }
            Console.Write("Gracias por utilizar este programa, ojalá te haya sido de ayuda.");
            Console.ReadLine();
        }
    }
}
