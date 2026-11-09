using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCSharp;

internal class Divisao
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Divisão");
        Console.WriteLine("Digite o primeiro número para a divisão: ");
        int numero01 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número para a divisão: ");
        int numero02 = Convert.ToInt32(Console.ReadLine());

        int resultadoDivisao = numero01 / numero02;

        Console.WriteLine("O resultado entre: " + numero01 + " / " + numero02 + " = " + resultadoDivisao);
    }
}
