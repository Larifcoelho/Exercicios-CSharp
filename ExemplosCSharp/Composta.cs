using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCSharp;

internal class Composta
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Estrutura de Decisão Composta");

        Console.WriteLine("Digite sua idade: ");
        int idade = Convert.ToInt16(Console.ReadLine());

        if (idade < 18)
        {
            Console.WriteLine("Você é menor de idade. ");
        }
        else
        {
            Console.WriteLine("Você é maior de idade.");
        }
    }
}
