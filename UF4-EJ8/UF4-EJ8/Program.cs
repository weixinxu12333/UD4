using System;

namespace UF4_EJ8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Recorriendo de 1 a 100 con while");
            int i = 0;
            while (i < 100) {
                Console.WriteLine(i+1);
                i++;
            }
        }
    }
}
