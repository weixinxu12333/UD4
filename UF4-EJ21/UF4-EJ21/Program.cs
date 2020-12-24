using System;

namespace UF4_EJ21
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduce un dia de la semana, sin tilde ni espacio blanco:");
            String dia = Console.ReadLine().ToLower();

            switch (dia)
            {
                case "lunes":
                    Console.WriteLine("Es dia laboral");
                    break;
                case "martes":
                    Console.WriteLine("Es dia laboral");
                    break;
                case "miercoles":
                    Console.WriteLine("Es dia laboral");
                    break;
                case "jueves":
                    Console.WriteLine("Es dia laboral");
                    break;
                case "viernes":
                    Console.WriteLine("Es dia laboral");
                    break;
                case "sabado":
                    Console.WriteLine("No es dia laboral");
                    break;
                case "domingo":
                    Console.WriteLine("No es dia laboral");
                    break;
                default:
                    Console.WriteLine("Hi ha error");
                    break;
            }
    }
}
}
