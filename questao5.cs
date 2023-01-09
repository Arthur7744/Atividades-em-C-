using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Um número é dito “perfeito”, se a soma de seus divisores menores que ele é igual a ele.Por
            //exemplo, o  número  6  possui os  divisores  1,  2  e  3,  cuja soma  é igual  a  6.O  número  28
            //também possui essa característica. Faça um programa que liste os números perfeitos entre 1
            //e 1000.
            
            int soma = 0;

            for (int i = 1; i <= 1000; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        soma = soma + j;
                        if (soma == i)
                            Console.WriteLine($"O número {i} é perfeito");
                    }
                }
                soma = 0;
            }
            Console.ReadKey();
        }
    }
}
