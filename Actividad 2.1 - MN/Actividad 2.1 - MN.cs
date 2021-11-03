using System;

namespace Actividad_2___MN
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora;
            bool validacion = false;
            int hora_recomendada = 0;

            Console.WriteLine("Ingresa la hora de dormir: ");
            hora = int.Parse(Console.ReadLine());

            do
            {
                if (hora >= 0 & hora <= 23) 
                {
                    validacion = true;
                }
                else
                {
                    Console.WriteLine("Error, ingresa nueva hora de dormir: ");
                    hora = int.Parse(Console.ReadLine());
                    validacion = false;
                }

            } while (!validacion);

            switch (hora)
            {
                case 23:
                case 0:
                case 1:
                    if (hora == 23)
                    {
                        hora_recomendada = 7;
                    }
                    else
                    {
                        hora_recomendada = hora + 8;
                    }
                    Console.WriteLine("Duerme usted un poco tarde, trate de descansar más, hora recomendada: " + hora_recomendada);
                    break;

                case 2:
                case 3:
                case 4:   
                    hora_recomendada = hora + 8;
                    Console.WriteLine("Usted duerme muy tarde, eso no es bueno para la salud, hora recomendada: " + hora_recomendada);
                    break;

                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    hora_recomendada = hora + 8;
                    Console.WriteLine("Supongo que duerme a estas horas porque tiene un trabajo nocturno, hora recomendada: " + hora_recomendada);
                    break;

                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                    if (hora == 18)
                    {
                        hora_recomendada = 0;
                    }
                    else
                    {
                        hora_recomendada = hora + 8;
                    }
                    Console.WriteLine("Usted tiene un horario de sueño muy extraño, hora recomendada: " + hora_recomendada);
                    break;

                case 19:
                case 20:
                    hora_recomendada = hora - 16;
                    Console.WriteLine("Usted duerme muy temprano, hora recomendada: " + hora_recomendada);
                    break;

                case 21:
                case 22:
                    hora_recomendada = hora - 16;
                    Console.WriteLine("Usted duerme a muy buena hora, felicidades, hora recomendada: " + hora_recomendada);
                    break;
            }

               
            
        }
    }
}
