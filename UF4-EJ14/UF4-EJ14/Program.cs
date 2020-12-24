using System;

namespace UF4_EJ14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de circulo");
            Console.WriteLine("Introduce radio:");
            string r = Console.ReadLine();
            double radio = Convert.ToDouble(r);
            const double p = Math.PI;
            double circulo = p * Math.Pow(radio, 2);
            Console.WriteLine("Resultado: " + circulo);

        }
    }
}
