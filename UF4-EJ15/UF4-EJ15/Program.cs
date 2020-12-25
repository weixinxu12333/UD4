using System;

namespace UF4_EJ15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero: ");
            string n = Console.ReadLine();
            int num = Convert.ToInt32(n);
            if (num % 2 == 0) {
                Console.WriteLine("Es divisible");
            } else {
                Console.WriteLine("No es divisible");
            }
        }
    }
}
