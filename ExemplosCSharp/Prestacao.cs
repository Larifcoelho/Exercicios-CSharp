using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCSharp
{
    internal class Prestacao
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa Prestação");
            Console.WriteLine("-------------------");

            Console.WriteLine("Digite o valor: ");
            double valor = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Digite a taxa: ");
            double taxa = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Digite o tempo definido: ");
            int tempo = Convert.ToInt32(Console.ReadLine());

            double prestacao = valor + (valor * taxa / 100) * tempo;

            Console.WriteLine("O valor da prestação é de: " + prestacao);
        }


    }
}
