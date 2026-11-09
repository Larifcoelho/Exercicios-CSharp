using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCSharp;

internal class Encadeada
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Estrutura de Decisão Encadeada");

        Console.WriteLine("Digite sua idade: ");
        int idade = Convert.ToInt16(Console.ReadLine());

        if (idade < 16)
        {
            Console.WriteLine("Você não pode votar. ");
        }
        else if (idade < 18)
        {
            Console.WriteLine("O voto é opcional.");
        }
        else
        {
            Console.WriteLine("Voto obrigatório. ");
        }
    }
}
