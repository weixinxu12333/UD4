using System;

namespace UF4_EJ11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 20, n2 = 20;

            if (n1 > n2) {
                Console.WriteLine(n1 + " es mayor que " + n2);
            }else if (n2 > n1)
            {
                Console.WriteLine(n2 + " es mayor que " + n1);
            }
            else if (n1 == n2)
            {
                Console.WriteLine(n1 + " y " + n1 + " son iguales");
            }
        }
    }
}
