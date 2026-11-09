using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCSharp;

internal class Multiplicacao
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Multiplicação");
        Console.WriteLine("Digite o primeiro número para a multiplicação: ");
        int numero01 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número para a multiplicação: ");
        int numero02 = Convert.ToInt32(Console.ReadLine());

        int resultadoMultiplicacao = numero01 * numero02;

        Console.WriteLine("O resultado entre: " + numero01 + " X " + numero02 + " = " + resultadoMultiplicacao);
    }
}
