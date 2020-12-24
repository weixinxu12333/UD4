using System;

namespace CalculadoraInversa
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10, n2 = 3;

            Console.WriteLine("Operaciones disponibles: " +
                "+ (suma), - (resta), * (multiplica), / (dividir), ^ (exponente), % (modulo)");
            string signo = Console.ReadLine();

            switch (signo)
            {
                case "+":
                    Console.WriteLine("Suma: " + (n1 + n2));
                    break;
                case "-":
                    Console.WriteLine("Resta: " + (n1 - n2));
                    break;
                case "*":
                    Console.WriteLine("Multiplica: " + (n1 * n2));
                    break;
                case "/":
                    Console.WriteLine("Dividir: " + (n1 / n2));
                    break;
                case "^":
                    Console.WriteLine("Exponente: " + (Math.Pow(n1, n2)));
                    break;
                case "%":
                    Console.WriteLine("Modulo: " + (n1 % n2));
                    break;
                default:
                    Console.WriteLine("Has introducido mal");
                    break;
            }

        }
    }
}
