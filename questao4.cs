using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que verifique se um número N inteiro fornecido pelo usuário é primo.

            int n, cont = 0;

            Console.WriteLine("Escreva um número inteiro: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
                Console.WriteLine("É um número primo");
            else
                Console.WriteLine("Não é um número primo.");

            Console.ReadKey();  
        }
    }
}
