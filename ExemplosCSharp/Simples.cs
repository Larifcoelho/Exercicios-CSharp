using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCSharp;

internal class Simples
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Programa de Decisão Simples");

        Console.WriteLine("Digite sua idade: ");
        int idade = Convert.ToInt16(Console.ReadLine());

        if (idade < 18)
        {
            Console.WriteLine("Você é menor de idade.");
        }
    }
}
