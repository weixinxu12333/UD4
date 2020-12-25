using System;

namespace UF4_EJ22
{
    class Program
    {
        static void Main(string[] args)
        {
            string contrasena = "abcd";
            int intento = 0;
            while (intento < 3)
            {
                Console.WriteLine("Introduce la contraseña: ");
                string c = Console.ReadLine();
                if (c.Equals(contrasena))
                {
                    Console.WriteLine("Enhorabuena!");
                    break;
                }
                intento++;
            }
        }
    }
}
