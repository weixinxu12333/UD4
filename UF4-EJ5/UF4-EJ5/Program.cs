using System;

namespace UF4_EJ5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce un dia de la semana, sin tilde ni espacio blanco:");
            String dia = Console.ReadLine().ToLower();

            if (dia == "lunes") {
                Console.WriteLine("No es fin de semana");
            }
            else if (dia == "martes")
            {
                Console.WriteLine("No es fin de semana");
            }
            else if (dia == "miercoles")
            {
                Console.WriteLine("No es fin de semana");
            }
            else if (dia == "jueves")
            {
                Console.WriteLine("No es fin de semana");
            }
            else if (dia == "viernes")
            {
                Console.WriteLine("No es fin de semana");
            }
            else if (dia == "sabado")
            {
                Console.WriteLine("Es fin de semana");
            }
            else if (dia == "domingo")
            {
                Console.WriteLine("Es fin de semana");
            }
            else
            {
                Console.WriteLine("Has introducido mal");
            }

        }
    }
}
