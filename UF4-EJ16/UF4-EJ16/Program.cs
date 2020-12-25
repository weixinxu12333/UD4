using System;

namespace UF4_EJ16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introducir un numero que puede tener con decimal: ");
            string n = Console.ReadLine();
            double num = Convert.ToDouble(n);
            const int iva = 21;
            double suma = num + (num * iva / 100);
            Console.WriteLine("Suma: "+ suma);
        }
    }
}
