using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCSharp
{
    internal class Soma
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Soma");
            Console.WriteLine("Digite o primeiro número para a soma: ");
            int numero01 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número para a soma: ");
            int numero02 = Convert.ToInt32(Console.ReadLine());

            int resultadoSoma = numero01 + numero02;

            Console.WriteLine("O resultado entre: " + numero01 + " + " + numero02 + " = " + resultadoSoma);
        }
    }
}
