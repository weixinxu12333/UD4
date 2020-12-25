using System;

namespace UF4_EJ6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Precio de un producto:");
            string pr = Console.ReadLine();
            double precio = Convert.ToDouble(pr);
            if (precio <= 0)
            {
                Console.WriteLine("El precio tiene que ser positivo!");
            }
            else if (precio > 0)
            {
                Console.WriteLine("Pagas con tarjeta? Introduce SI o NO");
                string respuesta = Console.ReadLine().ToUpper();
                if (respuesta == "SI")
                {
                    Console.WriteLine("Introduce su numero de cuenta:");
                    string numC = Console.ReadLine();
                    int numCuenta = Convert.ToInt32(numC);
                    Console.WriteLine("Pagado con tarjeta {0} con importe {1}", numCuenta, precio);
                }
                else if (respuesta == "NO")
                {
                    Console.WriteLine("De acuerdo, pagas con efectivo");
                }
                else
                {
                    Console.WriteLine("Has introduit malament");
                }
            }
        }
    }
}
