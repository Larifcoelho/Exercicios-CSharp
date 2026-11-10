using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCSharp
{
    internal class Conversao02
    {
        public static void Main(string[] args) {
            Console.WriteLine("Programa Fahrenheit Para Celsius");
            Console.WriteLine("-------------------------------- ");

            Console.WriteLine("Digite a temperatura em fahrenheit: ");
            double f = Convert.ToDouble(Console.ReadLine());

            double celsius = (f - 32) * 5/9;

            Console.WriteLine($"A conversão para celsius é de: {celsius}°C");
        }
    }
}
