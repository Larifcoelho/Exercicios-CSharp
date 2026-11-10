using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCSharp
{
    internal class Conversao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa Celsius Para Fahrenheit");
            Console.WriteLine("-------------------------------- ");

            Console.WriteLine("Digite a temperatura em celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double f = (9 * celsius + 160) / 5;
            Console.WriteLine($"A conversão para fahrenheit é de: {f}°F");
        }
    }
}
