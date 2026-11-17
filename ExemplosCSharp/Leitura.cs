using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCSharp
{
    internal class Leitura
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um nome: ");
            string b = Console.ReadLine();

            Console.WriteLine("Digite um nome: ");
            double c = Convert.ToDouble(Console.ReadLine());

            int c2 = a;
            string a2 = b;
            double b2 = c;

            Console.WriteLine(b2);
            Console.WriteLine(c2);
            Console.WriteLine(a2);

        }
    }
}
