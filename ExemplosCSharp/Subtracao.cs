using System;
using System.Collections.Generic;
using System.Text;

namespace ExemplosCSharp
{
    internal class Subtracao
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Subtração");
            Console.WriteLine("Digite o primeiro número para a subtração: ");
            int numero01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número para a subtração: ");
            int numero02 = Convert.ToInt32(Console.ReadLine());

            int resultadoSubtracao = numero01 - numero02;

            Console.WriteLine("O resultado entre: " + numero01 + " - " + numero02 + " = " + resultadoSubtracao);
        }
    }
}
