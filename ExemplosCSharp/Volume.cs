using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace ExerciciosCSharp
{
    internal class Volume
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa Volume Lata de Óleo");
            Console.WriteLine("----------------------------");

            Console.WriteLine("Digite o raio da lata de óleo: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura da lata de óleo: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double pi = Math.PI;
            double expoente = 2;
            double potencia = Math.Pow(raio, expoente);

            double volume = pi * potencia * altura;

            Console.WriteLine($"O volume é igual a: {volume:F2}");


        }
    }
}
