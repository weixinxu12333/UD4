using System;

namespace UF4_EJ9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mostrando numeros pares de 1 a 100 con for");
            for (int i = 1; i < 101; i++)
            {
                if (i%2==0) { 
                    Console.WriteLine(i);
                }
            }
        }
    }
}
