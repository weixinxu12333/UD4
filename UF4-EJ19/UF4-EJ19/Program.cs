using System;

namespace UF4_EJ19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mostrando numeros pares o divisibles entre 3 de 1 a 100 con while");
            int i = 1;
            while (i < 101)
            {
                if (i % 2 == 0 || i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
