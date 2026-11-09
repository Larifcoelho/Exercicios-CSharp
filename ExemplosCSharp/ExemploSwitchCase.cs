using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosCSharp;

internal class ExemploSwitchCase
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Programa Switch Case");
        Console.WriteLine("Digite um número de 1 a 7 e descubra o dia da semana:");
        int diaSemana = Convert.ToInt16(Console.ReadLine());

        switch (diaSemana)
        {
            case 1:
                    Console.WriteLine("Domingo");
                break;

            case 2:
                Console.WriteLine("Segunda");
                break;

            case 3:
                Console.WriteLine("Terça");
                break;

            case 4:
                Console.WriteLine("Quarta");
                break;

            case 5:
                Console.WriteLine("Quinta");
                break;

            case 6:
                Console.WriteLine("Sexta");
                break;

            case 7:
                Console.WriteLine("Sábado");
                break; 

            default:
                Console.WriteLine("Inválido. Digite novamente.");
                break;

        }
    }
}
