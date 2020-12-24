using System;

namespace UF4_EJ20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de venta: ");
            string n = Console.ReadLine();
            int num = Convert.ToInt32(n);

            int i = 0;
            double suma = 0;

            while (i < num)
            {
                Console.WriteLine("Venta{0}: ", (i+1));
                string v = Console.ReadLine();
                int venta = Convert.ToInt32(v);
                suma = suma + venta;
                i++;
            }

            Console.WriteLine("Venta total: " + suma);
        }
    }
}
