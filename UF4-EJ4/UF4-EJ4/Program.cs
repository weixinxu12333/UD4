using System;

namespace UF4_EJ4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce num 1:");
            String num1 = Console.ReadLine();
            int n1 = Convert.ToInt32(num1);

            Console.WriteLine("Introduce num 2:");
            String num2 = Console.ReadLine();
            int n2 = Convert.ToInt32(num2);

            if (n1 > n2) {
                Console.WriteLine("Numero " + n1 + " es mayor");
            } else if (n2>n1) {
                Console.WriteLine("Numero " + n2 + " es mayor");
            }
        }
    }
}
