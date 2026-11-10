using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCSharp
{
    internal class Combustivel
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa Média Combustível");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Digite o tempo gasto durante a viagem: ");
            double tempoGasto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a velocidade média durante a viagem: ");
            double velocidade = Convert.ToDouble(Console.ReadLine());

            double distancia = tempoGasto * velocidade;
            double litrosGasto = distancia/12;

            Console.WriteLine($"A velocidade média é de: {velocidade} \n" +
                $"O tempo gasto foi de: {tempoGasto} \n" + 
                $"A distancia percorrida foi de: {distancia} \n" +
                $"A quantidade de litros gasto foi de: {litrosGasto}");
        }
    }
}
//litrosGasto, carro faz 12km por litro;
//entrada user: tempoGasto,velocidade,
//processar: distancia = tempoGasto * velocidade, litrosGasto= distancia/12
//saida: velocidade, tempoGasto, distancia, litrosGasto