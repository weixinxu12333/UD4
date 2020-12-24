using System;

namespace UF4_EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un nombre:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Escribe una ciudad:");
            string ciudad = Console.ReadLine();

            Console.WriteLine("Hola {0}, bienvenido a {1}!", nombre, ciudad );
        }
    }
}
