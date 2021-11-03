using System;

namespace Actividad_2._3___MN
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Introduce un número: ");
            n = int.Parse(Console.ReadLine());

            while (n > 1 )
            {
                if (n % 2 == 0)
                { 
                    n /= 2;
                    Console.WriteLine(n);
                }
                else
                {
                    n += 1;
                    Console.WriteLine(n);
                }
            }
            
                   
                
            
        }
    }
}
