using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia um número inteiro N e forneça o resultado das séries A e B:

            int n;
            double soma1 = 0, soma2 = 100;

            Console.WriteLine("Escreva um número N para descobrir sua séries A e B: ");
            n = int.Parse(Console.ReadLine());

            for (double i = 2; i <= n; i++)
            {
                soma1 = soma1 + i - 1 / i;
            }

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                    soma2 = soma2 + i;
                else
                    soma2 = soma2 - i;
            }

            Console.WriteLine($"Valor da série A: {soma1}. /n Valor da série B: {soma2}.");

            Console.ReadKey();
        }
    }
}
